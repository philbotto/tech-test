using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Domain.Entities;

namespace TechTest.Service.Test.AutoMappings
{
    [TestClass]
    public class PersonDtoMappingTest
    {
        [TestInitialize]
        public void Setup()
        {
            Bootstrap.LoadAutoMapppings();
        }

        [TestMethod]
        public void PersonDtoMapping_ShouldMapProperties()
        {
            var person = new Person()
            {
                PersonId = 1,
                FirstName = "Joe",
                LastName = "Bloggs",
                IsAuthorised = false,
                IsValid = true,
                IsEnabled = true
            };

            var personDto = Mapper.Map<PersonDto>(person);

            Assert.AreEqual(person.PersonId, personDto.PersonId);
            Assert.AreEqual(person.FirstName, personDto.FirstName);
            Assert.AreEqual(person.LastName, personDto.LastName);
            Assert.AreEqual(person.IsAuthorised, personDto.IsAuthorised);
            Assert.AreEqual(person.IsValid, personDto.IsValid);
            Assert.AreEqual(person.IsEnabled, personDto.IsEnabled);
            Assert.AreEqual(person.FullName, personDto.FullName);
            Assert.AreEqual(person.IsPalindrome, personDto.IsPalindrome);
        }
    }
}
