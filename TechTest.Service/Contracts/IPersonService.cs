using System.Collections.Generic;
using System.Threading.Tasks;
using TechTest.Domain.Dtos;

namespace TechTest.Service.Contracts
{
    public interface IPersonService
    {
        Task<List<PersonDto>> GetPeopleAsync();
        Task<PersonDto> GetPersonAsync(int id);
        Task<PersonDto> UpdatePersonAsync(int id, PersonDto personParams);
    }
}
