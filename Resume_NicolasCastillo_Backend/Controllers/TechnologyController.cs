using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TechnologyController : Controller
    {
        private readonly ITechnologyService _technologyService;
        public TechnologyController(ITechnologyService technologyService)
        {
            _technologyService = technologyService;
        }

        [HttpGet("{personId}")]
        public IActionResult GetTechnologies(int personId)
        {
            var technologies = _technologyService.GetTechnologies(personId);
            return Ok(technologies);
        }
    }
}
