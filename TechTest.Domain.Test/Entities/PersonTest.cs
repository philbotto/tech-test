using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Entities;

namespace TechTest.Domain.Test.Entities
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void FullName_ShouldJoinNames()
        {
            var person = new Person
            {
                FirstName = "Joe",
                LastName = "Bloggs"
            };

            Assert.AreEqual("Joe Bloggs", person.FullName);
        }

        [TestMethod]
        public void IsPalindrome_ShouldDetectPalindrome()
        {
            var person = new Person
            {
                FirstName = "Bo",
                LastName = "Bob"
            };

            Assert.IsTrue(person.IsPalindrome);
        }
    }
}
