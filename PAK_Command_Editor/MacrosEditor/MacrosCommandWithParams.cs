using PAK_Command_Editor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.MacrosEditor
{
    public class MacrosCommandWithParams : MacrosCommand
    {
        public List<String> Params { get; set; }

        public MacrosCommandWithParams()
        {
            this.Params = new List<String>();
        }

        public MacrosCommandWithParams(MacrosCommand command) : this()
        {
            this.Alias = command.Alias;
            this.Id = command.Id;
            this.HexCode = command.HexCode;
            this.NumberOfParams = command.NumberOfParams;
        }
    }
}
