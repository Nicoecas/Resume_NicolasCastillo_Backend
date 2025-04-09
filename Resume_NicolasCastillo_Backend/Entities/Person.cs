namespace Resume_NicolasCastillo_Backend.Entities
{
    public class Person : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public string GitHub { get; set; } = string.Empty;
        public string DescriptionCard { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public List<Language> Languages { get; set; } = new List<Language>();
        public List<Technology> Technologies { get; set; } = new List<Technology>();
        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Certification> Certifications { get; set; } = new List<Certification>();
    }
}
