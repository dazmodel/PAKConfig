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

            GlobalVariable target = GlobalVariablesStorage.GetByName(parameters[1]);
            result.AddRange(PAKConversionUtilities.Int16ToByteArray(target.HexCode));

            String signalHexHash = parameters[0];
            using (Repository<Signal> signalsRepo = new Repository<Signal>(PAKDataSessionFactory.GetSession()))
            {
                Signal signal = signalsRepo.Get(x => x.HexCodeHash.Equals(signalHexHash)).SingleOrDefault();
                result.AddRange(PAKConversionUtilities.WordsStringToByteArray(signal.HexCode));
            }            

            return result.ToArray();
        }

        #endregion
    }
}
