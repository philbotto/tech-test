using System.Collections.Generic;
using System.Threading.Tasks;
using TechTest.Domain.Dtos;

namespace TechTest.Service.Contracts
{
    public interface IColourService
    {
        Task<List<ColourDto>> GetColoursAsync();
    }
}
