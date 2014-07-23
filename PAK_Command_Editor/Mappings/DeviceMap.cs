using FluentNHibernate.Mapping;
using PAK_Command_Editor.Entities;

namespace PAK_Command_Editor.Mappings
{
    public class DeviceMap : ClassMap<Device>
    {
        public DeviceMap()
        {
            Table("DevicesModels");
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Vendor);
            HasMany(x => x.SupportedSignals);
        }
    }
}
