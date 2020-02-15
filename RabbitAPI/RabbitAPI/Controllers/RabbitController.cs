using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitAPI.Model;

namespace RabbitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Rabbit r1 = new Rabbit()
            {

            };
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rabbit
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Rabbit/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
