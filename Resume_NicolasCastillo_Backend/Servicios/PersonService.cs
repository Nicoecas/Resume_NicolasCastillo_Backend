using Resume_NicolasCastillo_Backend.Dtos;
using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Entities;
using AutoMapper;

namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface IPersonService
    {
        public PersonGeneralDto GetPerson(int id);
    }
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        public PersonService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PersonGeneralDto GetPerson(int id)
        {
            var person = InMemoryDb.Instance.FirstOrDefault<Person>(x => id == x.Id);
            if (person == null)
                throw new Exception("Person not found");

            var personDto = _mapper.Map<PersonGeneralDto>(person);
            return personDto;
        }
    }
}
