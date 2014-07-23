using FluentNHibernate.Mapping;
using PAK_Command_Editor.Entities;

namespace PAK_Command_Editor.Mappings
{
    public class MacrosCommandMap : ClassMap<MacrosCommand>
    {
        public MacrosCommandMap()
        {
            Table("MacrosCommands");
            Id(x => x.Id);
            Map(x => x.Alias);
            Map(x => x.HexCode);
            Map(x => x.NumberOfParams);
        }
    }
}
