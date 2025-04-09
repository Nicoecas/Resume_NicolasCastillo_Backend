using AutoMapper;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Responses
{
    public class CertificationProfile : Profile
    {
        public CertificationProfile()
        {
            CreateMap<Certification, CertificationDto>();
        }
    }

    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<Education, EducationDto>();
        }
    }

    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageDto>();
        }
    }

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonGeneralDto>();
        }
    }

    public class TechnologyProfile : Profile
    {
        public TechnologyProfile()
        {
            CreateMap<Technology, TechnologyDto>();
        }
    }

    public class WorkExperienceProfile : Profile
    {
        public WorkExperienceProfile()
        {
            CreateMap<WorkExperience, WorkExperienceDto>();
        }
    }
}
