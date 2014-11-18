using System.Collections.Generic;
using System.Threading.Tasks;
using TechTest.Domain.Dtos;
using TechTest.Service.Contracts;

namespace TechTest.Test.Mocks
{
    public class ColourServiceMock : IColourService
    {
        private readonly List<ColourDto> _colourDtos;

        public ColourServiceMock(List<ColourDto> colourDtos)
        {
            _colourDtos = colourDtos;
        }

        public Task<List<ColourDto>> GetColoursAsync()
        {
            return Task.FromResult(_colourDtos);
        }
    }
}
