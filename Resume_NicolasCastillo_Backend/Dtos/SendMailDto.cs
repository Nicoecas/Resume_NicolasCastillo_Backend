namespace Resume_NicolasCastillo_Backend.Dtos
{
    public class SendMailDto
    {
        public string Email { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
