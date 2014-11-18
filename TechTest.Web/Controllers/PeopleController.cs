using System.Threading.Tasks;
using System.Web.Http;
using TechTest.Domain.Dtos;
using TechTest.Service.Contracts;

namespace TechTest.Web.Controllers
{
    [RoutePrefix("api/people")]
    public class PeopleController : ApiController
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Route]
        public async Task<IHttpActionResult> Index()
        {
            var people = await _personService.GetPeopleAsync();
            return Ok(people);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> Show(int id)
        {
            var person = await _personService.GetPersonAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IHttpActionResult> Update(int id, [FromBody] PersonDto personParams)
        {
            var person = await _personService.UpdatePersonAsync(id, personParams);

            if (person == null)
            {
                return NotFound();
            }
            
            return Ok(person);
        }
    }
}
