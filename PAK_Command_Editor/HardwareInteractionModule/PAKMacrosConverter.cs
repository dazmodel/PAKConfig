using PAK_Command_Editor.Entities;
using PAK_Command_Editor.MacrosEditor;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.Settings;
using PAK_Command_Editor.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.HardwareInteractionModule
{
    public static class PAKMacrosConverter
    {
        public static readonly Int32 LENGTH_PREAMBLE_SIZE = 4;
        public static readonly Int32 MIN_COMMANDS_LENGTH = 5;
        public static readonly Int16 INT32_PARAM_SIZE = 4;
        public static readonly Int16 STR_PARAM_SIZE = 6;
        public static readonly Int16 PARAMS_CONTAINER_SIZE = 2;
        public static readonly Int16 GLOBAL_VAR_SIZE = 2;
        public static readonly Int16 SEND_PREAMBLE_SIZE = 8;
        public static readonly Int16 SIGNAL_LENGTH_PART_SIZE = 4;

        public static byte[] GetSignalByteRepresentation(MacrosesContainer container)
        {
            List<byte> bytesToSend = new List<byte>();
            bytesToSend.AddRange(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.WriteSignalCommand));
            byte[] signalHex = PAKConversionUtilities.WordsStringToByteArray(container.AssociatedSignal.HexCode);
            bytesToSend.AddRange(PAKConversionUtilities.Int32ToByteArray(signalHex.Length));
            bytesToSend.AddRange(signalHex);

            return bytesToSend.ToArray();
        }

        public static byte[] GetMacrosesByteRepresentation(MacrosesContainer container)
        {
            List<byte> bytesToSend = new List<byte>();
            bytesToSend.AddRange(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.WriteMacrosCommand));

            List<byte> dataBytes = new List<byte>();
            foreach (MacrosCommand command in container.Commands)
            {
                dataBytes.Add(command.HexCode);
                dataBytes.AddRange(ParamsToByteArray(command));
            }

            bytesToSend.AddRange(PAKConversionUtilities.Int32ToByteArray(dataBytes.Count));
            bytesToSend.AddRange(dataBytes);
            return bytesToSend.ToArray();
        }

        public static Signal GetSignalFromByteRepresentation(byte[] signalData)
        {
            byte[] signalWithoutLengthData = TrimLengthPart(signalData);            
            String signalHexHash = Signal.ComputeMD5Hash(PAKConversionUtilities.ByteArrayToSignalWordsString(signalWithoutLengthData).ToLower());
            Signal signal = null;
            using (Repository<Signal> signalsRepo = new Repository<Signal>(PAKDataSessionFactory.GetSession()))
            {
                try
                {
                    signal = signalsRepo.Get(x => x.HexCodeHash.Equals(signalHexHash)).SingleOrDefault();
                }
                catch { }
            }
            return signal;
        }

        public static List<MacrosCommand> GetCommandsFromByteRepresentation(byte[] commandsData)
        {
            byte[] commandsWithoutLength = TrimLengthPart(commandsData);

            if (commandsWithoutLength.Length >= MIN_COMMANDS_LENGTH)
            {
                List<MacrosCommand> commands = new List<MacrosCommand>();
                Int32 index = 0;
                using (Repository<MacrosCommand> commandsRepo = new Repository<MacrosCommand>(PAKDataSessionFactory.GetSession()))
                {
                    do
                    {
                        byte commandCode = commandsWithoutLength[index];
                        index++;

                        MacrosCommand command;
                        try
                        {
                            command = commandsRepo.Get(x => x.HexCode == commandCode).SingleOrDefault();
                            command.Params = GetParamsFromByteArray(command, commandsWithoutLength, ref index);
                            commands.Add(command);
                        }
                        catch
                        {
                            return null;
                        }


                    } while (index < commandsWithoutLength.Length);
                }

                return commands;
            }

            return null;
        }

        #region Utilities

        private static byte[] ParamsToByteArray(MacrosCommand command)
        {
            List<byte> result = new List<byte>();
            MacrosCommandType commnadType = (MacrosCommandType)Enum.Parse(typeof(MacrosCommandType), command.Alias);

            switch (commnadType)
            {
                case MacrosCommandType.DELAY:
                    String delayString = command.Params[0];
                    Int32 delay;
                    if (Int32.TryParse(delayString, out delay))
                    {
                        result.AddRange(PAKConversionUtilities.Int32ToByteArray(delay));
                    }
                    break;
                case MacrosCommandType.SET:
                case MacrosCommandType.RESET:
                case MacrosCommandType.IF:
                    result.AddRange(PAKConversionUtilities.StringToASCIIByteCodesArray(command.Params[0]));
                    break;
                case MacrosCommandType.SEND:
                    result.AddRange(SendParamsToByteArray(command.Params));
                    break;
            }

            return result.ToArray();
        }

        private static byte[] SendParamsToByteArray(List<String> parameters)
        {
            List<byte> result = new List<byte>();            

            String signalHexHash = parameters[0];
            using (Repository<Signal> signalsRepo = new Repository<Signal>(PAKDataSessionFactory.GetSession()))
            {
                Signal signal = signalsRepo.Get(x => x.HexCodeHash.Equals(signalHexHash)).SingleOrDefault();
                result.AddRange(PAKConversionUtilities.WordsStringToByteArray(signal.HexCode));
            }

            GlobalVariable target = GlobalVariablesStorage.GetByName(parameters[1]);
            result.AddRange(PAKConversionUtilities.Int16ToByteArray(target.HexCode));

            return result.ToArray();
        }

        private static byte[] TrimLengthPart(byte[] data)
        {
            Int32 length = data.Length - LENGTH_PREAMBLE_SIZE;
            byte[] inputWithoutLengthData = new byte[length];
            Array.Copy(data, LENGTH_PREAMBLE_SIZE, inputWithoutLengthData, 0, length);
            return inputWithoutLengthData;
        }

        private static List<String> GetParamsFromByteArray(MacrosCommand command, byte[] commandsData, ref Int32 index)
        {
            MacrosCommandType commnadType = (MacrosCommandType)Enum.Parse(typeof(MacrosCommandType), command.Alias);
            List<String> parameters = new List<String>(PARAMS_CONTAINER_SIZE);

            switch (commnadType)
            {
                case MacrosCommandType.DELAY:
                    if (commandsData.Length >= (index + INT32_PARAM_SIZE))
                    {
                        Int32 delay = PAKConversionUtilities.ByteArrayToInt32(commandsData, index);
                        index += INT32_PARAM_SIZE;
                        parameters.Add(delay.ToString());
                        break;
                    }
                    else
                        return null;

                case MacrosCommandType.SET:
                case MacrosCommandType.RESET:
                case MacrosCommandType.IF:
                    if (commandsData.Length >= (index + STR_PARAM_SIZE))
                    {
                        String globalVarAlias = PAKConversionUtilities.ASCIIByteArrayToString(commandsData, index, STR_PARAM_SIZE);
                        globalVarAlias = globalVarAlias.Trim("\0".ToArray());
                        index += STR_PARAM_SIZE;
                        parameters.Add(globalVarAlias);
                        break;
                    }
                    else
                        return null;

                case MacrosCommandType.SEND:
                    return GetSendParamsFromByteArray(commandsData, ref index);
                    
            }
            return parameters;
        }

        private static List<String> GetSendParamsFromByteArray(byte[] byteArray, ref Int32 index)
        {
            if (byteArray.Length >= (index + GLOBAL_VAR_SIZE + SEND_PREAMBLE_SIZE))
            {
                Int32 signalLength = (PAKConversionUtilities.ByteArrayToInt32(byteArray, index + (SEND_PREAMBLE_SIZE - SIGNAL_LENGTH_PART_SIZE)) * 2) * 2 + SEND_PREAMBLE_SIZE;
                if (byteArray.Length >= (index + signalLength))
                {
                    List<String> result = new List<String>();
                    try
                    {
                        String signalHexHash = Signal.ComputeMD5Hash(PAKConversionUtilities.ByteArrayToSignalWordsString(byteArray, index, signalLength).ToLower());
                        index += signalLength;
                        Signal signal;
                        using (Repository<Signal> signalsRepo = new Repository<Signal>(PAKDataSessionFactory.GetSession()))
                        {
                            signal = signalsRepo.Get(x => x.HexCodeHash.Equals(signalHexHash)).SingleOrDefault();
                        }

                        Int16 gvHexCode = PAKConversionUtilities.ByteArrayToInt16(byteArray, index);
                        index += GLOBAL_VAR_SIZE;
                        GlobalVariable gv;
                        using (Repository<GlobalVariable> gvRepo = new Repository<GlobalVariable>(PAKDataSessionFactory.GetSession()))
                        {
                            gv = gvRepo.Get(x => x.HexCode == gvHexCode).SingleOrDefault();
                        }
                                                
                        result.Add(signal.Name);
                        result.Add(gv.Alias);
                    }
                    catch
                    {
                        return null;
                    }

                    return result;
                }
                return null;
            }

            return null;
        }

        #endregion
    }
}
