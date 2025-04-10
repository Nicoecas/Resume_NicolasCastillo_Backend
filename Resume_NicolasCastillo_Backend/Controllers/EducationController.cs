using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet("{personId}")]
        public IActionResult GetTechnologies(int personId)
        {
            var educations = _educationService.GetEducations(personId);
            return Ok(educations);
        }
    }
}
