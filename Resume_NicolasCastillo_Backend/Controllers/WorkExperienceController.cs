using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkExperienceController : Controller
    {
        private readonly IWorkExperienceService _workExperienceService;
        public WorkExperienceController(IWorkExperienceService workExperienceService)
        {
            _workExperienceService = workExperienceService;
        }

        [HttpGet("{personId}")]
        public IActionResult GetPersonById(int personId)
        {
            var workExperiences = _workExperienceService.GetWorkExperiences(personId);
            return Ok(workExperiences);
        }
    }
}
