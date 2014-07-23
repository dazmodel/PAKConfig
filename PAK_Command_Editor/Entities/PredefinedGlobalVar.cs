using System;

namespace PAK_Command_Editor.Entities
{
    public class PredefinedGlobalVar
    {
        public virtual Int32 Id { get; set;}
        public virtual String Alias { get; set; }
        public virtual byte[] HexCode { get; set; }

        public PredefinedGlobalVar()
        {
            this.HexCode = new byte[2];
        }
    }
}
