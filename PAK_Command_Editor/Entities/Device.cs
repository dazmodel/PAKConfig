using System;
using System.Collections.Generic;

namespace PAK_Command_Editor.Entities
{
    public class Device
    {
        public virtual Int32 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual IList<Signal> SupportedSignals { get; set; }

        public Device()
        {
            this.SupportedSignals = new List<Signal>();
        }

        public virtual void AddSignal(Signal signal)
        {
            signal.Device = this;
            this.SupportedSignals.Add(signal);
        }
    }
}
