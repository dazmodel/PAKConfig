using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PAK_Command_Editor.Settings
{
    public static class PAKSettingsManager
    {
        private static readonly String DEFAULT_DB_LOCATION = @"C:\\PAK.sqlite";
        private static readonly String DEFAULT_TEACHING_COMMAND = "0x7F 0x01";
        private static readonly String DEFAULT_TEST_COMMAND = "0x7F 0x02";
        private static readonly String DEFAULT_COM_NAME = "COM1";
        private static readonly Int32 DEFAULT_COM_READ_TIMEOUT = 4000;
        private static readonly String DEFAULT_READ_SIGNAL_COMMAND = "0x7F 0x20";
        private static readonly String DEFAULT_READ_MACROS_COMMAND = "0x7F 0x21";
        private static readonly String DEFAULT_WRITE_SIGNAL_COMMAND = "0x7F 0x10";
        private static readonly String DEFAULT_WRITE_MACROS_COMMAND = "0x7F 0x11";
        private static readonly Int32 DEFAULT_COM_BAND = 9600;

        private static readonly String SETTINGS_FILE_NAME = "settings.xml";
        private static PAKSettings _settings;

        public static PAKSettings Settings
        {
            get
            {
                if (_settings != null) return _settings;

                if(File.Exists(SETTINGS_FILE_NAME))
                {
                    _settings = DeserializeSettings();
                    if (_settings != null)
                        return _settings;
                }

                _settings = GetDefaults();
                SaveSettings();
                return _settings;
            }
        }

        public static void SaveSettings()
        {
            try
            {
                XDocument doc = new XDocument();
                using (var writer = doc.CreateWriter())
                {
                    // write xml into the writer
                    var serializer = new XmlSerializer(_settings.GetType());
                    serializer.Serialize(writer, _settings);
                }
                doc.Save(SETTINGS_FILE_NAME);
            }
            catch (Exception)
            {
                
            }
        }

        private static PAKSettings DeserializeSettings()
        {
            PAKSettings settings = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PAKSettings));
                using (StreamReader reader = new StreamReader(SETTINGS_FILE_NAME))
                {
                    settings = (PAKSettings)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                
            }

            return settings;
        }

        private static PAKSettings GetDefaults()
        {
            return new PAKSettings()
                       {
                           DataBaseLocation = DEFAULT_DB_LOCATION,
                           TeachingCommand = DEFAULT_TEACHING_COMMAND,
                           TestCommand = DEFAULT_TEST_COMMAND,
                           COMPortName = DEFAULT_COM_NAME,
                           COMPortBandwidth = DEFAULT_COM_BAND,
                           COMReadTimeout = DEFAULT_COM_READ_TIMEOUT,
                           ReadSignalCommand = DEFAULT_READ_SIGNAL_COMMAND,
                           ReadMacrosCommand = DEFAULT_READ_MACROS_COMMAND,
                           WriteSignalCommand = DEFAULT_WRITE_SIGNAL_COMMAND,
                           WriteMacrosCommand = DEFAULT_WRITE_MACROS_COMMAND
                       };
        }
    }
}
