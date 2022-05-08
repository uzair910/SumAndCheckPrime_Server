using NUnit.Framework;
using Services;

namespace ServiceTests
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        [Test, Description("Test to check IsPrime extension method for int.")]
        [TestCase(3, ExpectedResult = true, Description = "Test if method returns true for a known prime number that is greater than 2.")]
        [TestCase(0, ExpectedResult = false, Description = "Test if method returns false for integer 0.")]
        [TestCase(-4, ExpectedResult = false, Description = "Test if method returns false for any number below zero.")]
        [TestCase(20, ExpectedResult = false, Description = "Test if method returns false for a known non-prime number that is greater than 2.")]
        [TestCase(37, ExpectedResult = true, Description = "Test if method returns true for a known prime number that is greater than 2.")]
        public bool Test_IsPrime_ExtensionMethod(int iValue)
        {
            return iValue.IsPrime();
        }

        [Test, Description("Test GetSpecialSum extension method for string.")]
        [TestCase("3", ExpectedResult = 3, Description = "Test if method works for just one number in the string.")]
        [TestCase("", ExpectedResult = int.MinValue, Description = "Test if method returns int.MinValue for empty string.")]
        [TestCase("3,1,,", ExpectedResult = int.MinValue, Description = "Test if method returns int.MinValue  for invalid input string.")]
        [TestCase("14, 3,5,8", ExpectedResult = 30, Description = "Test if method works for multiple numbers in the string.")]
        [TestCase("-4, 3, 10", ExpectedResult =  9, Description = "Test if method works for multiple numbers in the string containing atleast one negative number.")]
        public int Test_GetSpecialSum_ExtensionMethod(string sValue)
        {
            return sValue.GetSpecialSum();
        }
    }
}