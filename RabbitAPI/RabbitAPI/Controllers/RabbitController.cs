using Microsoft.AspNetCore.Mvc;
using RabbitAPI.Models;
using System.Collections.Generic;

namespace RabbitAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        

        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            Rabbit r1 = new Rabbit()
            {
                FurColors = FurColors.White,
                EyeColors = EyeColors.Blue,
                Gender = Gender.Female, 
                DateOfBirth = new System.DateTime(2019, 06, 11)
                
            };

            Rabbit r2 = new Rabbit()
            {
                FurColors = FurColors.Grey,
                EyeColors = EyeColors.Red,
                Gender = Gender.Male,
                DateOfBirth = new System.DateTime(2001, 4, 11)

            };
           List<Rabbit> myRabbits = new List<Rabbit>();
            myRabbits.Add(r1);
            myRabbits.Add(r2);
            return myRabbits;


   
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rabbit
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            if (ModelState.IsValid)
            {
                //save in database
                
                return Ok();
            }
            return BadRequest();

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
