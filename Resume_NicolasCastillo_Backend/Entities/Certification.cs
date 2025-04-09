namespace Resume_NicolasCastillo_Backend.Entities
{
    public class Certification : BaseEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = default!;
        public string Name { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
