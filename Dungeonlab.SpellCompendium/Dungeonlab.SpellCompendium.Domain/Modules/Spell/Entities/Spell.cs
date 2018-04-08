using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Dungeonlab.SpellCompendium.Domain.Modules.Spell.ValuedObjects;

namespace Dungeonlab.SpellCompendium.Domain.Modules.Spell.Entities
{
    [DataContract(Name ="spell")]
    public class Spell
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "casttime")]
        public string CastTime { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "duration")]
        public string Duration { get; set; }

        [DataMember(Name = "range")]
        public int Range { get; set; }

        [DataMember(Name = "components")]
        public ICollection<SpellComponent> Components { get; set; }

        [DataMember(Name = "effects")]
        public ICollection<SpellEffect> Effects { get; set; }

        [DataMember(Name = "savestat")]
        public string SaveStat { get; set; }

        [DataMember(Name = "element")]
        public string Element { get; set; }
    }
}
