using System.Threading.Tasks;
using System.Web.Http;
using TechTest.Service.Contracts;

namespace TechTest.Web.Controllers
{
    [RoutePrefix("api/colours")]
    public class ColoursController : ApiController
    {
        private readonly IColourService _colourService;

        public ColoursController(IColourService colourService)
        {
            _colourService = colourService;
        }

        [HttpGet]
        [Route]
        public async Task<IHttpActionResult> Index()
        {
            var colours = await _colourService.GetColoursAsync();
            return Ok(colours);
        }
    }
}
