using LeetCode.LongestCommonPrefix;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestLongestCommonPrefix
    {
        [Test]
        public void Test_Case1()
        {
            var input  = new[] {"flower", "flow", "flight"};
            var output = "fl";

            Assert.AreEqual(output, new Solution().LongestCommonPrefix(input));
        }

        [Test]
        public void Test_Case2()
        {
            var input  = new[] {"dog", "racecar", "car"};
            var output = "";

            Assert.AreEqual(output, new Solution().LongestCommonPrefix(input));
        }
    }
}