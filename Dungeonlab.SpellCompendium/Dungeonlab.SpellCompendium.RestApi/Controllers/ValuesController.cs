using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dungeonlab.SpellCompendium.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace Dungeonlab.SpellCompendium.RestApi.Controllers
{
    [Route("api/spells")]
    public class ValuesController : Controller
    {
        private readonly ISpellRepository _spellRepository;
        private readonly ILogger<ValuesController> _logger;
        
        public ValuesController(ILogger<ValuesController> logger, ISpellRepository spellRepository)
        {
            _logger = logger;
            _spellRepository = spellRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id > 0)
                {
                    var spell = _spellRepository.Get(id);
                    if (spell != null)
                        return Ok(spell);
                    else
                        return NotFound();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"There was an error retrieving element {id}. Ex: {ex}");
                return BadRequest();
            }
            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
