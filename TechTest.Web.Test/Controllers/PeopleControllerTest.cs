using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Dtos;
using TechTest.Test.Mocks;
using TechTest.Web.Controllers;

namespace TechTest.Web.Test.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        [TestMethod]
        public async Task Index_ShouldReturnAllPeople()
        {
            var people = new List<PersonDto>
            {
                new PersonDto(),
                new PersonDto(),
                new PersonDto()
            };

            var personService = new PersonServiceMock(people);
            var controller = new PeopleController(personService);

            var result = await controller.Index() as OkNegotiatedContentResult<List<PersonDto>>;
            Assert.AreEqual(people.Count, result.Content.Count);
        }

        [TestMethod]
        public async Task Show_ShouldReturnPerson()
        {
            var people = new List<PersonDto>
            {
                new PersonDto()
                {
                    PersonId = 1
                }
            };

            var personService = new PersonServiceMock(people);
            var controller = new PeopleController(personService);

            var result = await controller.Show(1) as OkNegotiatedContentResult<PersonDto>;
            Assert.AreEqual(1, result.Content.PersonId);
        }

        [TestMethod]
        public async Task Show_ShouldReturnPersonNotFound()
        {
            var people = new List<PersonDto>
            {
                new PersonDto()
                {
                    PersonId = 1
                }
            };

            var personService = new PersonServiceMock(people);
            var controller = new PeopleController(personService);

            var result = await controller.Show(2);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Update_ShouldReturnPerson()
        {
            var people = new List<PersonDto>
            {
                new PersonDto()
                {
                    PersonId = 1
                }
            };

            var personService = new PersonServiceMock(people);
            var controller = new PeopleController(personService);

            var result = await controller.Show(1) as OkNegotiatedContentResult<PersonDto>;
            Assert.AreEqual(1, result.Content.PersonId);
        }

        [TestMethod]
        public async Task Update_ShouldReturnPersonNotFound()
        {
            var people = new List<PersonDto>
            {
                new PersonDto()
                {
                    PersonId = 1
                }
            };

            var personService = new PersonServiceMock(people);
            var controller = new PeopleController(personService);

            var result = await controller.Update(2, new PersonDto());
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
