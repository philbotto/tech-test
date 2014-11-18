using System.Linq;
using TechTest.Domain.Entities;

namespace TechTest.Test.Mocks
{
    public class ColorsDbSetMock : DbSetMock<Colour>
    {
        public override Colour Find(params object[] keyValues)
        {
            return this.SingleOrDefault(product => product.ColourId == (int)keyValues.Single());
        }
    }
}
