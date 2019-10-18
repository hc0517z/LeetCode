using LeetCode.RomanToInteger;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestRomanToInteger
    {
        [Test]
        public void Test_Case1()
        {
            var input  = "III";
            var output = 3;

            Assert.AreEqual(output, new Solution().RomanToInt(input));
        }

        [Test]
        public void Test_Case2()
        {
            var input  = "IV";
            var output = 4;

            Assert.AreEqual(output, new Solution().RomanToInt(input));
        }

        [Test]
        public void Test_Case3()
        {
            var input  = "IX";
            var output = 9;

            Assert.AreEqual(output, new Solution().RomanToInt(input));
        }

        [Test]
        public void Test_Case4()
        {
            var input  = "LVIII";
            var output = 58;

            Assert.AreEqual(output, new Solution().RomanToInt(input));
        }

        [Test]
        public void Test_Case5()
        {
            var input  = "MCMXCIV";
            var output = 1994;

            Assert.AreEqual(output, new Solution().RomanToInt(input));
        }
    }
}