using System;

namespace PAK_Command_Editor.Entities
{
    public class GlobalVariable
    {
        public virtual Int32 Id { get; set;}
        public virtual String Alias { get; set; }
        public virtual byte[] HexCode { get; set; }
        public virtual Boolean Value { get; set; }

        public GlobalVariable()
        {
            this.HexCode = new byte[2];
        }
    }
}
