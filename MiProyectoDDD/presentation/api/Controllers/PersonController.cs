
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using application.application.services.person;
using domain.entities.persons;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _iPersonService;

        private readonly ILogger<PersonController> _logger;        

        public PersonController(IPersonService iPersonService, ILogger<PersonController> logger)
        {
            this._iPersonService = iPersonService;
            _logger = logger;
        }

        [HttpGet]
        public List<Person> Get()
        {
            List<Person> response = new List<Person>();
            try
            {
                response = _iPersonService.GetPersons();

            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
            return response;
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            Person response = new Person();
            try
            {
                response = _iPersonService.GetPerson(id);

            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
            return response;
        }

        [HttpPost]
        public void Post([FromBody] Person person)
        {
            try
            {
                _iPersonService.Create(person);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person person)
        {
            try
            {
                Person _person = new Person();
                _person = person;
                _person.Id = id;
                _iPersonService.Update(_person);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _iPersonService.DeletePerson(id);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
        }

    }
}
