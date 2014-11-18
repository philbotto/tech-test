using TechTest.Domain.Extensions;

namespace TechTest.Domain.Entities
{
    public partial class Person
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsPalindrome 
        {
            get { return FullName.IsPalindrome(); }
        }
    }
}
