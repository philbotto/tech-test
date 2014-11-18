using System.Data.Entity;
using System.Threading.Tasks;
using TechTest.Data.Contracts;
using TechTest.Domain.Entities;

namespace TechTest.Test.Mocks
{
    public class TechTestEntitiesMock : ITechTestEntities
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Colour> Colours { get; set; }

        public TechTestEntitiesMock()
        {
            People = new PeopleDbSetMock();
            Colours = new ColorsDbSetMock();
        }

        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(0);
        }

        public void Dispose() { }
    }
}
