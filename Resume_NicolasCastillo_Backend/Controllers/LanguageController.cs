using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;
        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("{personId}")]
        public IActionResult GetTechnologies(int personId)
        {
            var technologies = _languageService.GetLanguages(personId);
            return Ok(technologies);
        }
    }
}
