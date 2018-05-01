using Dungeonlab.SpellCompendium.Domain.Repositories;
using System;
using Dungeonlab.SpellCompendium.Domain.Modules.Spell.Entities;
using System.Collections.Generic;

namespace Dungeonlab.SpellCompendium.FileProvider
{
    public class TestSpellRepository : ISpellRepository
    {
        public Spell Get(int id)
        {
            if (id == 5) return new Spell { Id = "45", Name = "Test spell" }; 
            throw new NotImplementedException();
        }

        public IEnumerable<Spell> Get()
        {
            throw new NotImplementedException();
        }
    }
}
