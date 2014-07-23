using FluentNHibernate.Mapping;
using PAK_Command_Editor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.Mappings
{
    public class PredefinedGlobalVarMap : ClassMap<PredefinedGlobalVar>
    {
        public PredefinedGlobalVarMap()
        {
            Table("PredefinedGlobalVars");
            Id(x => x.Id);
            Map(x => x.Alias);
            Map(x => x.HexCode);
        }
    }
}
