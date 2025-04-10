namespace Resume_NicolasCastillo_Backend.Dtos
{
    public class TechnologyDto
    {
        public int Id { get; set; }
        public string TechnologyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
    }

    public class GroupedTechnology
    {
        public string TypeName { get; set; } = string.Empty;
        public List<TechnologyDto> Technologies { get; set; } = new List<TechnologyDto>();
    }
}
