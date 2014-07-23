using FluentNHibernate.Mapping;
using PAK_Command_Editor.Entities;

namespace PAK_Command_Editor.Mappings
{
    public class VendorMap : ClassMap<Vendor>
    {
        public VendorMap()
        {
            Table("Vendors");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            HasMany(x => x.Devices);
        }
    }
}
