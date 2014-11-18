using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Service.Entities;
using TechTest.Test.Mocks;

namespace TechTest.Service.Test.Entities
{
    [TestClass]
    public class ColourServiceTest
    {
        [TestMethod]
        public async Task GetColours_ShouldReturnDtos()
        {
            var testEntities = new TechTestEntitiesMock();
            var colourService = new ColourService(testEntities);

            var result = await colourService.GetColoursAsync();

            Assert.IsInstanceOfType(result, typeof(List<ColourDto>));
        }
    }
}
