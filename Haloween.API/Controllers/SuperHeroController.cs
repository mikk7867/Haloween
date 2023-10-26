using Haloween.Repo.DTO;
using Haloween.Repo.Interfaces;
using Haloween.Repo.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Haloween.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        ISuperHeroRepo superHeroRepo { get; set; }
        public SuperHeroController(ISuperHeroRepo super)
        {
            this.superHeroRepo = super;
        }
        // GET: api/<SuperHeroController>
        [HttpGet]
        public List<SuperHero> Get()
        {
            return superHeroRepo.GetAll();
        }
        /*
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */
        [HttpGet("ny")]
        public int tal()
        {
            return 1;
        }

        // GET api/<SuperHeroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SuperHeroController>
        [HttpPost]
        public void Post([FromBody] SuperHero value)
        {
            superHeroRepo.Create(value);
        }

        // PUT api/<SuperHeroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuperHeroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            superHeroRepo.Delete(id);
        }
    }
}
