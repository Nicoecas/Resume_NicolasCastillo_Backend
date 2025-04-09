using System.ComponentModel.DataAnnotations;

namespace Resume_NicolasCastillo_Backend.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedDate { get; set; }
    }
}

