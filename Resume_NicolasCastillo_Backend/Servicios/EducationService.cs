using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface IEducationService
    {
        public List<EducationDto> GetEducations(int personId);
    }
    public class EducationService : IEducationService
    {
        private readonly IMapper _mapper;
        public EducationService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<EducationDto> GetEducations(int personId)
        {
            var educations = InMemoryDb.Instance.ListAll<Education>(p => p.PersonId == personId);
            var educationDtos = _mapper.Map<List<EducationDto>>(educations);
            return educationDtos;
        }
    }
}
