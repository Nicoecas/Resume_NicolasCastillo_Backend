using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface IWorkExperienceService
    {
        public List<WorkExperienceDto> GetWorkExperiences(int personId);
    }
    public class WorkExperienceService : IWorkExperienceService
    {
        private readonly IMapper _mapper;
        public WorkExperienceService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<WorkExperienceDto> GetWorkExperiences(int personId)
        {
            var workExperiences = InMemoryDb.Instance.ListAll<WorkExperience>(p => p.PersonId == personId);
            var workExperienceDtos = _mapper.Map<List<WorkExperienceDto>>(workExperiences);
            return workExperienceDtos;
        }
    }
}
