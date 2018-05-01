using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dungeonlab.SpellCompendium.Domain.Modules.Spell.ValuedObjects
{
    [DataContract]
    public class SpellComponent
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "requirement")]
        public string Requirement { get; set; }
    }
}
