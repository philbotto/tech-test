using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Domain.Entities;

namespace TechTest.Service.Test.AutoMappings
{
    [TestClass]
    public class ColourDtoMappingTest
    {
        [TestInitialize]
        public void Setup()
        {
            Bootstrap.LoadAutoMapppings();
        }

        [TestMethod]
        public void ColourDtoMapping_ShouldMapProperties()
        {
            var colour = new Colour()
            {
                ColourId = 1,
                Name = "Red",
                IsEnabled = true
            };

            var colourDto = Mapper.Map<ColourDto>(colour);

            Assert.AreEqual(colour.ColourId, colourDto.ColourId);
            Assert.AreEqual(colour.Name, colourDto.Name);
            Assert.AreEqual(colour.IsEnabled, colourDto.IsEnabled);
        }
    }
}
