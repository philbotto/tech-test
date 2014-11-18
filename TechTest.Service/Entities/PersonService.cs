using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TechTest.Data.Contracts;
using TechTest.Domain.Dtos;
using TechTest.Domain.Entities;
using TechTest.Service.Contracts;

namespace TechTest.Service.Entities
{
    public class PersonService : IPersonService
    {
        private readonly ITechTestEntities _context;

        public PersonService(ITechTestEntities context)
        {
            _context = context;
        }

        public async Task<List<PersonDto>> GetPeopleAsync()
        {
            var people = await _context.People.Include(p => p.Colours).OrderBy(p => p.FirstName).ToListAsync();
            var peopleDtos = Mapper.Map<List<PersonDto>>(people);

            return peopleDtos;
        }

        public async Task<PersonDto> GetPersonAsync(int id)
        {
            var person = await FindPersonAsync(id);
            return person == null ? null : Mapper.Map<PersonDto>(person);
        }

        public async Task<PersonDto> UpdatePersonAsync(int id, PersonDto personParams)
        {
            var person = await FindPersonAsync(id);

            if (person == null)
            {
                return null;
            }

            person.IsAuthorised = personParams.IsAuthorised;
            person.IsEnabled = personParams.IsEnabled;

            await UpdateColoursAsync(personParams, person);
            await _context.SaveChangesAsync();

            return Mapper.Map<PersonDto>(person);
        }

        private async Task UpdateColoursAsync(PersonDto personParams, Person person)
        {
            person.Colours.Clear();

            if (personParams.Colours == null || personParams.Colours.Any() == false)
                return;
            
            var colourIds = personParams.Colours.Select(c => c.ColourId);
            var colours = await _context.Colours.Where(c => colourIds.Contains(c.ColourId)).ToListAsync();

            foreach (var colour in colours)
            {
                person.Colours.Add(colour);
            }
        }

        private async Task<Person> FindPersonAsync(int id)
        {
            return await _context.People.Include(p => p.Colours).SingleOrDefaultAsync(p => p.PersonId == id);
        }
    }
}
