using System.ComponentModel.DataAnnotations;

namespace Resume_NicolasCastillo_Backend.Entities
{
    public class Education : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = default!;
        public string Institution { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        [Display(Name = "Start Date")]
        public int StartDate { get; set; }
        [Display(Name = "End Date")]
        public int? EndDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Finalized { get; set; } = false;
    }
}
