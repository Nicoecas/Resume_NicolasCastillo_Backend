using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ITechnologyService
    {
        public List<TechnologyDto> GetTechnologies(int personId);
    }
    public class TechnologyService : ITechnologyService
    {
        private readonly IMapper _mapper;
        public TechnologyService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<TechnologyDto> GetTechnologies(int personId)
        {
            var technologies = InMemoryDb.Instance.ListAll<Technology>(p => p.PersonId == personId);
            var technologyDtos = _mapper.Map<List<TechnologyDto>>(technologies);
            return technologyDtos;
        }
    }
}
