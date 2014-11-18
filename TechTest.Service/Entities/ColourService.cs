using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TechTest.Data.Contracts;
using TechTest.Domain.Dtos;
using TechTest.Service.Contracts;

namespace TechTest.Service.Entities
{
    public class ColourService : IColourService
    {
        private readonly ITechTestEntities _context;

        public ColourService(ITechTestEntities context)
        {
            _context = context;
        }

        public async Task<List<ColourDto>> GetColoursAsync()
        {
            var colours = await _context.Colours.OrderBy(c => c.Name).ToListAsync();
            var colourDtos = Mapper.Map<List<ColourDto>>(colours);
            
            return colourDtos;
        }
    }
}
