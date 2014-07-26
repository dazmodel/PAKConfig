using System;

namespace PAK_Command_Editor.Entities
{
    public class GlobalVariable
    {
        public virtual Int32 Id { get; set;}
        public virtual String Alias { get; set; }
        public virtual Int16 HexCode { get; set; }
        public virtual Boolean Value { get; set; }
        public virtual Boolean CanReceiveSignals { get; set; }        
    }
}
