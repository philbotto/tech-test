using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTest.Domain.Dtos;
using TechTest.Service.Contracts;

namespace TechTest.Test.Mocks
{
    public class PersonServiceMock : IPersonService
    {
        private readonly List<PersonDto> _personDtos;

        public PersonServiceMock(List<PersonDto> personDtos)
        {
            _personDtos = personDtos;
        }

        public Task<List<PersonDto>> GetPeopleAsync()
        {
            return Task.FromResult(_personDtos);
        }

        public Task<PersonDto> GetPersonAsync(int id)
        {
            var personDto = _personDtos.FirstOrDefault(p => p.PersonId == id);;
            return Task.FromResult(personDto);
        }

        public Task<PersonDto> UpdatePersonAsync(int id, PersonDto personParams)
        {
            return GetPersonAsync(id);
        }
    }
}
