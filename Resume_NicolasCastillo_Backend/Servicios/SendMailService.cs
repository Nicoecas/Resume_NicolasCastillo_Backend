using System.Net.Mail;
using System.Net;
using Resume_NicolasCastillo_Backend.Dtos;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ISendMailService
    {
        void SendEmail(SendMailDto sendMailDto);
    }
    public class SendMailService : ISendMailService
    {
        private IConfigurationService _IConfig;
        private readonly string _fromEmail;
        private readonly string _toEmail;
        private readonly string _password;
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        public SendMailService(IConfigurationService iConfig)
        {
            _IConfig = iConfig;
            _fromEmail = _IConfig.GetSetting("Email", "FromEmail");
            _toEmail = _IConfig.GetSetting("Email", "ToEmail");
            _password = _IConfig.GetSetting("Email", "Password");
            _smtpServer = _IConfig.GetSetting("Email", "SmtpServer");
            _smtpPort = Int16.Parse(_IConfig.GetSetting("Email", "SmtpPort"));
            if (string.IsNullOrEmpty(_fromEmail) || string.IsNullOrEmpty(_toEmail) ||
                string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_smtpServer) || _smtpPort <= 0)
            {
                throw new InvalidOperationException("Configuración de correo electrónico no válida.");
            }
        }
        
        public void SendEmail(SendMailDto sendMailDto)
        {
            if (sendMailDto == null ||
                string.IsNullOrEmpty(sendMailDto.Email) ||
                string.IsNullOrEmpty(sendMailDto.Body) ||
                string.IsNullOrEmpty(sendMailDto.Subject))
            {
                throw new Exception("Los datos del correo no pueden ser nulos.");
            }

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = sendMailDto.Subject,
                Body = sendMailDto.Body +$"\n" +
                $" Mensaje desde: " + sendMailDto.Email,
                IsBodyHtml = false 
            };
            mail.To.Add(_toEmail);

          
            using (SmtpClient smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(_fromEmail, _password);

                smtpClient.Send(mail);
            }
        }
    }
}
