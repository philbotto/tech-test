using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Domain.Extensions;

namespace TechTest.Domain.Test.Extensions
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void IsPalindrome_ShouldBeCaseInsensitive()
        {
            const string str = "bo BOB";

            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void IsPalindrome_ShouldBeSpaceInsensitive()
        {
            const string str = "bo   B O B";

            Assert.IsTrue(str.IsPalindrome());
        }
    }
}
