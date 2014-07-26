using System;
using System.Collections.Generic;

namespace PAK_Command_Editor.Entities
{
    public class MacrosCommand
    {
        public virtual Int32 Id { get; set; }
        public virtual String Alias { get; set; }
        public virtual byte HexCode { get; set; }
        public virtual Int32 NumberOfParams { get; set; }
        public virtual List<String> Params { get; set; }

        public MacrosCommand()
        {
            this.Params = new List<String>();
        }        
    }
}
