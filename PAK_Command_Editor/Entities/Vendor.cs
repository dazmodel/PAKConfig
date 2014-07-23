using System;
using System.Collections.Generic;

namespace PAK_Command_Editor.Entities
{
    public class Vendor
    {
        public virtual Int32 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual IList<Device> Devices { get; set; }

        public Vendor()
        {
            this.Devices = new List<Device>();
        }

        public virtual void AddDevice(Device device)
        {
            device.Vendor = this;
            this.Devices.Add(device);
        }
    }
}
