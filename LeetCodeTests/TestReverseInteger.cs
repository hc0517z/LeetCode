using LeetCode.ReverseInteger;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestReverseInteger
    {
        [Test]
        public void Test_Case1()
        {
            var input = 123;
            var output = 321;
            Assert.AreEqual(output, new Solution().Reverse(input));
        }
        
        [Test]
        public void Test_Case2()
        {
            var input = -123;
            var output = -321;
            Assert.AreEqual(output, new Solution().Reverse(input));
        }
        
        [Test]
        public void Test_Case3()
        {
            var input = 120;
            var output = 21;
            Assert.AreEqual(output, new Solution().Reverse(input));
        }
        
        [Test]
        public void Test_Case4()
        {
            var input = -2147483648;
            var output = 0;
            Assert.AreEqual(output, new Solution().Reverse(input));
        }
    }
}