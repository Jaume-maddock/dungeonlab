using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dungeonlab.SpellCompendium.Domain.Modules.Spell.ValuedObjects
{
    [DataContract]
    public class SpellComponent
    {
        [DataMember(Name = "casttime")]
        public string Type { get; set; }

        [DataMember(Name = "casttime")]
        public string Requirement { get; set; }
    }
}
