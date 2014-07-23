using FluentNHibernate.Mapping;
using PAK_Command_Editor.Entities;

namespace PAK_Command_Editor.Mappings
{
    public class SignalMap : ClassMap<Signal>
    {
        public SignalMap() 
        {
            Table("SupportedSignals");
            Id(x => x.HexCodeHash);
            Map(x => x.Name);
            Map(x => x.HexCode);
            References(x => x.Device);
        }
    }
}
