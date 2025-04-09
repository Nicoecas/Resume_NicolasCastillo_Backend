using Microsoft.OpenApi.Extensions;

namespace Resume_NicolasCastillo_Backend.Dtos
{
    public class LanguageDto
    {
        public string Name { get; set; } = string.Empty;
        public string LevelDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
