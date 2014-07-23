using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.CustomEventArgs
{
    public class ComPortDataEventArgs : EventArgs
    {
        public byte[] ReceivedData { get; set; }
    }
}
