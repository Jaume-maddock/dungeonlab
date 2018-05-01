using Dungeonlab.SpellCompendium.Domain.Modules.Spell.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeonlab.SpellCompendium.Domain.Repositories
{
    public interface ISpellRepository
    {
        Spell Get(int id);

        IEnumerable<Spell> Get();
    }
}
