
using Microsoft.OpenApi.Extensions;
using Resume_NicolasCastillo_Backend.Entities;
using System.ComponentModel.DataAnnotations;

namespace Resume_NicolasCastillo_Backend
{
    public class Language : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = default!;
        public string Name { get; set; } = string.Empty;
        public Level Level { get; set; }
        public string LevelDescription => Level.GetDisplayName() ?? string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public enum Level
    {
        [Display(Name = "Beginner")]
        Beginner = 1,
        [Display(Name = "Intermediate")]
        Intermediate = 2,
        [Display(Name = "Upper-Intermediate")]
        UpperIntermediate = 3,
        [Display(Name = "Advanced")]
        Advanced = 4,
        [Display(Name = "Native")]
        Native = 5
    }
}
