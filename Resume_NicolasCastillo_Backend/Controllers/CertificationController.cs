using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CertificationController : Controller
    {
        private readonly ICertificationService _certificationService;
        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        [HttpGet("{personId}")]
        public IActionResult GetCertifications(int personId)
        {
            var technologies = _certificationService.GetCertifications(personId);
            return Ok(technologies);
        }
    }
}
