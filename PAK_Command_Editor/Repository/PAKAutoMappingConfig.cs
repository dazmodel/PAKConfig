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
        private static readonly IList<String> IgnoredMembers = new List<String> { "Value" };

        public override bool ShouldMap(Member member)
        {
            return base.ShouldMap(member) && !IgnoredMembers.Contains(member.Name);
        }
    }
}
