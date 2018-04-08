using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Dungeonlab.SpellCompendium.Domain.Modules.Spell.ValuedObjects
{
    [DataContract]
    public class SpellEffect
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "levelspelleffects")]
        public ICollection<LevelSpellEffect> LevelSpellEffects { get; set; }
    }

    [DataContract]
    public class LevelSpellEffect
    {
        [DataMember(Name = "spelllevel")]
        public int SpellLevel { get; set; }

        [DataMember(Name = "success")]
        public string Success { get; set; }

        [DataMember(Name = "fail")]
        public string Fail { get; set; }

        [DataMember(Name = "effectrange")]
        public int EffectRange { get; set; }
    }
}
