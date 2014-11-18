using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TechTest.Domain.Entities;

namespace TechTest.Test.Mocks
{
    public class PeopleDbSetMock : DbSetMock<Person>
    {
        public async override Task<Person> FindAsync(params object[] keyValues)
        {
            return await this.SingleOrDefaultAsync(p => p.PersonId == (int)keyValues.Single());
        }
    }
}
