using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Domain.Entities;
using TechTest.Service.Entities;
using TechTest.Test.Mocks;

namespace TechTest.Service.Test.Entities
{
    [TestClass]
    public class PersonServiceTest
    {
        [TestInitialize]
        public void Setup()
        {
            Bootstrap.LoadAutoMapppings();   
        }

        [TestMethod]
        public async Task GetPeople_ShouldReturnDtos()
        {
            var testEntities = new TechTestEntitiesMock();
            var colourService = new PersonService(testEntities);

            var result = await colourService.GetPeopleAsync();

            Assert.IsInstanceOfType(result, typeof(List<PersonDto>));
        }

        [TestMethod]
        public async Task GetPerson_ShouldReturnDto()
        {
            var testEntities = new TechTestEntitiesMock();
            testEntities.People.Add(new Person { PersonId = 1});

            var colourService = new PersonService(testEntities);

            var result = await colourService.GetPersonAsync(1);

            Assert.AreEqual(1, result.PersonId);
        }

        [TestMethod]
        public async Task UpdatePerson_ShouldReturnDto()
        {
            var testEntities = new TechTestEntitiesMock();
            testEntities.People.Add(new Person { PersonId = 1 });

            var colourService = new PersonService(testEntities);

            var result = await colourService.UpdatePersonAsync(1, new PersonDto());

            Assert.AreEqual(1, result.PersonId);
        }
    }
}
