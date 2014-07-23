using PAK_Command_Editor.MacrosEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.CustomEventArgs
{
    public class ResultEntityEventArgs : EventArgs
    {
        public Int32 EntityId { get; set; }
        public MacrosCommandType CommandType { get; set; }
        public List<String> Params { get; set; }
    }
}
