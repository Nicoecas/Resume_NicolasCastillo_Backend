using AutoMapper;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Entities;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface ICertificationService
    {
        public List<CertificationDto> GetCertifications(int personId);
    }
    public class CertificationService : ICertificationService
    {
        private readonly IMapper _mapper;
        public CertificationService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<CertificationDto> GetCertifications(int personId)
        {
            var certifications = InMemoryDb.Instance.ListAll<Certification>(p => p.PersonId == personId);
            var certificationsDto = _mapper.Map<List<CertificationDto>>(certifications);
            return certificationsDto;
        }
    }
}
