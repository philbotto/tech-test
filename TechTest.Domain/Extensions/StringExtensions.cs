using System.Linq;

namespace TechTest.Domain.Extensions
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string stringValue)
        {
            stringValue = stringValue.ToLower().Replace(" ", string.Empty);
            return stringValue.SequenceEqual(stringValue.Reverse());
        }
    }
}
