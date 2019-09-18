using LeetCode.PalindromeNumber;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestPalindromeNumber
    {
        [Test]
        public void Test_Case1()
        {
            var input = 121;
            var output = true;
            
            Assert.AreEqual(output, new Solution().IsPalindrome(input));
        }
        
        [Test]
        public void Test_Case2()
        {
            var input = -121;
            var output = false;
            
            Assert.AreEqual(output, new Solution().IsPalindrome(input));
        }
        
        [Test]
        public void Test_Case3()
        {
            var input = 10;
            var output = false;
            
            Assert.AreEqual(output, new Solution().IsPalindrome(input));
        }
        
        [Test]
        public void Test_Case4()
        {
            var input = 1000000001;
            var output = true;
            
            Assert.AreEqual(output, new Solution().IsPalindrome(input));
        }
    }
}