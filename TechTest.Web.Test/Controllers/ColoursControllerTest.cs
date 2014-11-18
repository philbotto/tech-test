using System.Collections.Generic;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Test.Mocks;
using TechTest.Web.Controllers;

namespace TechTest.Web.Test.Controllers
{
    [TestClass]
    public class ColoursControllerTest
    {
        [TestMethod]
        public async void Index_ShouldReturnAllColours()
        {
            var colours = new List<ColourDto>
            {
                new ColourDto(),
                new ColourDto(),
                new ColourDto()
            };

            var colourService = new ColourServiceMock(colours);
            var controller = new ColoursController(colourService);

            var result = await controller.Index() as OkNegotiatedContentResult<List<ColourDto>>;
            Assert.AreEqual(colours.Count, result.Content.Count);
        }
    }
}
