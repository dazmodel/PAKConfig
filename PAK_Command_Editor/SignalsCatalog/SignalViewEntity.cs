using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.SignalsCatalog
{
    public class SignalViewEntity
    {
        public Int32 Id { get; set; }
        public String SignalName { get; set; }
        public String DeviceName { get; set; }
        public String VendorName { get; set; }
        public String HEXCode { get; set; }
    }
}
