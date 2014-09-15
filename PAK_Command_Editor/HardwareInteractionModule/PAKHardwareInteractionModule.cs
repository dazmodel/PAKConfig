using NHibernate.Mapping;
using PAK_Command_Editor.CustomEventArgs;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.MacrosEditor;
using PAK_Command_Editor.Settings;
using PAK_Command_Editor.Utilities;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAK_Command_Editor.HardwareInteractionModule
{
    public class PAKHardwareInteractionModule : IDisposable
    {
        public static readonly String DATA_SENT_SUCCESSFULLY_NO_WAIT = "Данные успешно отправлены в порт {0}";
        private static readonly String DATA_READ_TIMEOUT = "Истекло время ожидания ответа от порта {0}";
        private static readonly String CANT_READ_DATA = "Не удалось прочитать данные из порта {0}";
        private static readonly String DATA_READED = "Данные успешно получены из порта {0}";
        private static readonly String MACROS_READED = "Макрос успешно прочитан из устройства, подключенного к порту {0}";
        private static readonly String SIGNAL_NOT_READED = "Не удалось прочитать данные Сигнала из порта {0} {1}";
        private static readonly String MACROS_NOT_READED = "Не удалось прочитать данные Макроса из порта {0} {1}";
        private static readonly String EOL = "\r\n";
        private SerialPort _comPort;

        public event EventHandler<ComPortDataEventArgs> DataReceivedFromPort;

        public PAKHardwareInteractionModule()
        {
            this._comPort = new SerialPort(PAKSettingsManager.Settings.COMPortName, PAKSettingsManager.Settings.COMPortBandwidth);
        }

        public String SendTestCommand(String signalString)
        {
            List<byte> bytesToSend = new List<byte>();
            bytesToSend.AddRange(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.TestCommand));
            bytesToSend.AddRange(PAKConversionUtilities.WordsStringToByteArray(signalString));
            //bytesToSend.AddRange(PAKConversionUtilities.StringToASCIIByteCodesArray(EOL));

            return this.SendData(bytesToSend.ToArray());
        }

        public KeyValuePair<String, byte[]> SendTeachCommand()
        {
            String testSignal = "0000 0067 0000 0015 0060 0018 0018 0018 0030 0018 0030 0018 0030 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0030 0018 0030 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 0018 0018 0018 0030 0018 0018 03f6";
            List<byte> bytes = new List<byte>();
            bytes.AddRange(PAKConversionUtilities.WordsStringToByteArray(testSignal));
            bytes.AddRange(PAKConversionUtilities.StringToASCIIByteCodesArray(EOL));
            return new KeyValuePair<string, byte[]>("OK", bytes.ToArray());
            //return this.SendDataAndWait(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.TeachingCommand));
        }

        public String SendMacrosToDevice(MacrosesContainer macrosesContainer)
        {
            return this.SendData(PAKMacrosConverter.GetSignalByteRepresentation(macrosesContainer)) + "\r\n" +
            this.SendData(PAKMacrosConverter.GetMacrosesByteRepresentation(macrosesContainer));
                        
            //List<byte> signalBytes = PAKMacrosConverter.GetSignalByteRepresentation(macrosesContainer).ToList();
            //signalBytes.Add(byte.MinValue);
            //signalBytes.Add(byte.MinValue);
            //List<byte> macrosBytes = PAKMacrosConverter.GetMacrosesByteRepresentation(macrosesContainer).ToList();
           
            //MacrosesContainer mc = new MacrosesContainer();
            //mc.AssociatedSignal = PAKMacrosConverter.GetSignalFromByteRepresentation(signalBytes.Where(x => signalBytes.IndexOf(x) >= 2).ToArray());
            //byte[] tmp = new byte[macrosBytes.Count - 2];
            //System.Array.Copy(macrosBytes.ToArray(), 2, tmp, 0, macrosBytes.Count - 2);
            //mc.Commands = PAKMacrosConverter.GetCommandsFromByteRepresentation(tmp);
        }

        public KeyValuePair<String, MacrosesContainer> ReadMacrosFromDevice()
        {
            List<byte> inputData = new List<byte>();

            KeyValuePair<String, byte[]> inputSignalData = this.SendDataAndWait(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.ReadSignalCommand));

            if (inputSignalData.Value.Length == 0)            
            {
                return new KeyValuePair<String, MacrosesContainer>(String.Format(SIGNAL_NOT_READED, PAKSettingsManager.Settings.COMPortName, EOL) + 
                                                                                inputSignalData.Key, null);
            }

            KeyValuePair<String, byte[]> inputMacrosData = this.SendDataAndWait(PAKConversionUtilities.StringToByteArray(PAKSettingsManager.Settings.ReadMacrosCommand));

            if (inputMacrosData.Value.Length == 0)
            {
                return new KeyValuePair<String, MacrosesContainer>(String.Format(MACROS_NOT_READED, PAKSettingsManager.Settings.COMPortName, EOL) +
                                                                                inputMacrosData.Key, null);
            }

            try
            {
                MacrosesContainer macrosesContainer = new MacrosesContainer();
                macrosesContainer.AssociatedSignal = PAKMacrosConverter.GetSignalFromByteRepresentation(inputSignalData.Value);
                macrosesContainer.Commands = PAKMacrosConverter.GetCommandsFromByteRepresentation(inputMacrosData.Value);

                return new KeyValuePair<String, MacrosesContainer>(String.Format(MACROS_READED, PAKSettingsManager.Settings.COMPortName), macrosesContainer);
            }
            catch (Exception e)
            {
                return new KeyValuePair<String, MacrosesContainer>(e.Message, null);
            }
        }  

        #region Utilities        

        private String SendData(byte[] byteData)
        {
            try
            {
                if (this._comPort.IsOpen == false) //if not open, open the port
                    this._comPort.Open();

                this._comPort.Write(byteData, 0, byteData.Length);
                this._comPort.Close();
                return String.Format(DATA_SENT_SUCCESSFULLY_NO_WAIT, PAKSettingsManager.Settings.COMPortName);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private KeyValuePair<String, byte[]> SendDataAndWait(byte[] data)
        {
            try
            {
                if (this._comPort.IsOpen == false) //if not open, open the port
                    this._comPort.Open();

                this._comPort.DiscardInBuffer();
                this._comPort.DiscardOutBuffer();

                //send           
                this._comPort.Write(data, 0, data.Length);

                using (COMTimer tmrComm = new COMTimer())
                {
                    tmrComm.Start(PAKSettingsManager.Settings.COMReadTimeout);

                    //Waiting for data to read
                    while ((this._comPort.BytesToRead == 0) && (tmrComm.timedout == false))
                    {
                        Application.DoEvents();
                    }

                    if (this._comPort.BytesToRead > 0)
                    {
                        byte[] inbytes = new byte[this._comPort.BytesToRead];
                        this._comPort.Read(inbytes, 0, this._comPort.BytesToRead);
                        if (inbytes.Length > 0)
                        {
                            return new KeyValuePair<String, byte[]>(String.Format(DATA_READED, PAKSettingsManager.Settings.COMPortName), inbytes); 
                        }
                        else
                        {
                            return new KeyValuePair<String, byte[]>(String.Format(CANT_READ_DATA, PAKSettingsManager.Settings.COMPortName), new byte[0]);
                        }
                    }
                    else
                    {
                        return new KeyValuePair<String, byte[]>(String.Format(DATA_READ_TIMEOUT, PAKSettingsManager.Settings.COMPortName), new byte[0]);
                    }
                }                
            }
            catch (Exception e)
            {
                return new KeyValuePair<String, byte[]>(e.Message, new byte[0]);
            }
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            try
            {
                this._comPort.DiscardInBuffer();
                this._comPort.DiscardOutBuffer();
                this._comPort.Close();
            }
            catch { }
            finally
            {
                this._comPort.Dispose();
            }
        }

        #endregion
    }
}
