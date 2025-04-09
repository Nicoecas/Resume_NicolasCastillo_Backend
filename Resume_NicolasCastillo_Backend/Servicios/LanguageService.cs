using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ILanguageService
    {
        List<LanguageDto> GetLanguages(int personId);
    }
    public class LanguageService : ILanguageService
    {
        private readonly IMapper _mapper;
        public LanguageService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<LanguageDto> GetLanguages(int personId)
        {
            var languages = InMemoryDb.Instance.ListAll<Language>(p => p.PersonId == personId);
            var languageDtos = _mapper.Map<List<LanguageDto>>(languages);
            return languageDtos;
        }
    }
}
