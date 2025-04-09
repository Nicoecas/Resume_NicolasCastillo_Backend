using Microsoft.OpenApi.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Resume_NicolasCastillo_Backend.Entities
{
    public class Technology : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = default!;
        public string TechnologyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Type Type { get; set; }
        public string TypeName => Type.GetDisplayName() ?? string.Empty;
    }

    public enum Type
    {
        [Display(Name = "Lenguajes de programación")]
        Language = 1,
        [Display(Name = "Herramientas y Plataformas")]
        ToolPlatform = 2,
        [Display(Name = "Pruebas y Metodologías")]
        Methodology = 3,
        [Display(Name = "Tecnologías Web")]
        WebTechnology = 4,
        [Display(Name = "Framework y librerías")]
        FrameworkLibrary = 5,
    }
}
