using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourOfHeroesApi.Models;

namespace TourOfHeroesApi.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        // GET api/heroes
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return new Hero[] {
                new Hero(){Id=1,Name="First Hero"},
                new Hero(){Id=3,Name="Second Hero"}
             };
        }

        // GET api/heroes/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/heroes
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/heroes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/heroes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
