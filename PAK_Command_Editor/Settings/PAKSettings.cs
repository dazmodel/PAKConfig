using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.Settings
{
    public class PAKSettings
    {
        public String DataBaseLocation { get; set; }
        public String TeachingCommand { get; set; }
        public String TestCommand { get; set; }
        public String COMPortName { get; set; }
        public Int32 COMPortBandwidth { get; set; }
        public Int32 COMReadTimeout { get; set; }
        public String ReadSignalCommand { get; set; }
        public String ReadMacrosCommand { get; set; }
        public String WriteSignalCommand { get; set; }
        public String WriteMacrosCommand { get; set; }

    }
}
