using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiAspNetCore.Model;
using RestApiAspNetCore.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiAspNetCore.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PersonsController : Controller
    {
        private IPersonBusiness _personService;

        public PersonsController(IPersonBusiness personservice)
        {
            _personService = personservice;
        }


        // GET api/<PersonsController>/5
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _personService.FindById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // POST api/<PersonsController>
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
