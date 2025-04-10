using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ITechnologyService
    {
        List<GroupedTechnology> GetTechnologies(int personId);
    }
    public class TechnologyService : ITechnologyService
    {
        private readonly IMapper _mapper;
        public TechnologyService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<GroupedTechnology> GetTechnologies(int personId)
        {
            var technologies = InMemoryDb.Instance.ListAll<Technology>(p => p.PersonId == personId);
            var technologyDtos = _mapper.Map<List<TechnologyDto>>(technologies);
            var groupedTechnologies = technologyDtos
                .GroupBy(t => t.TypeName) 
                .Select(g => new GroupedTechnology
                {
                    TypeName = g.Key,
                    Technologies = g.ToList() 
                })
                .ToList();

            return groupedTechnologies;
        }
    }
}
