using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using Resume_NicolasCastillo_Backend.Dtos;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ISendMailService
    {
        Task SendEmail(SendMailDto sendMailDto);
    }

    public class SendMailService : ISendMailService
    {
        private IConfigurationService _IConfig;
        private readonly string _toEmail;
        private readonly string _secretKey;
        private readonly string _apiKey;

        public SendMailService(IConfigurationService iConfig)
        {
            _IConfig = iConfig;
            _toEmail = _IConfig.GetSetting("Mailjet", "ToMail");
            _secretKey = _IConfig.GetSetting("Mailjet", "SecretKey");
            _apiKey = _IConfig.GetSetting("Mailjet", "ApiKey");

            if (string.IsNullOrEmpty(_secretKey) || string.IsNullOrEmpty(_toEmail) ||
                string.IsNullOrEmpty(_apiKey))
            {
                throw new InvalidOperationException("Configuración de correo electrónico no válida.");
            }
        }

        public async Task SendEmail(SendMailDto sendMailDto)
        {
            MailjetClient client = new MailjetClient(_apiKey, _secretKey);

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, $"{sendMailDto.EmailFrom}")
            .Property(Send.FromName, $"{sendMailDto.Name}")
            .Property(Send.Subject, $"{sendMailDto.Subject}")
            .Property(Send.TextPart, $"{sendMailDto.Body}")
            .Property(Send.HtmlPart, $"<h1>Hola Nicolás!</h1><p>{sendMailDto.Body}</p>")
            .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", $"{_toEmail}"}
                 }
                });
            MailjetResponse response = await client.PostAsync(request);

            if (response.StatusCode != 200)
            {
                throw new Exception($"Error al enviar el correo: {response.GetErrorMessage()}");
            }
        }
    }
}
