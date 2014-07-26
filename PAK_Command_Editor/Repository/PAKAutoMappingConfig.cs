using FluentNHibernate;
using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAK_Command_Editor.Repository
{
    public class PAKAutoMappingConfig : DefaultAutomappingConfiguration
    {
        private static readonly IList<String> IgnoredMembers = new List<String> { "Value", "Params" };
        private static readonly String NamespaceToMap = "PAK_Command_Editor.Entities";

        public override bool ShouldMap(Type type)
        {
            return base.ShouldMap(type) && type.Namespace.Equals(NamespaceToMap);
        }

        public override bool ShouldMap(Member member)
        {            
            return base.ShouldMap(member) && !IgnoredMembers.Contains(member.Name);
        }
    }
}
