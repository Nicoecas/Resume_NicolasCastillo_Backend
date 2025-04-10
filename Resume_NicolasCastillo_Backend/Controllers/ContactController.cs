using Microsoft.AspNetCore.Mvc;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Servicios;

namespace Resume_NicolasCastillo_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ISendMailService _sendMailService;
        public ContactController(ISendMailService sendMailService)
        {
            _sendMailService = sendMailService;
        }

        [HttpPost]
        public IActionResult SendMail([FromBody]SendMailDto sendMail)
        {
            try
            {
                _sendMailService.SendEmail(sendMail);
                return Ok("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al enviar el correo: {ex.Message}");
            }
        }
    }
}
