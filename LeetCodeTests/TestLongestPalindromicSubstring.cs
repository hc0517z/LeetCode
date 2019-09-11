using LeetCode.LongestPalindromicSubstring;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestLongestPalindromicSubstring
    {
        [Test]
        public void Test_Case1()
        {
            var input = "babad";
            var expected = "aba";
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
        
        [Test]
        public void Test_Case2()
        {
            var input = "cbbd";
            var expected = "bb";
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
        
        [Test]
        public void Test_Case3()
        {
            var input = "a";
            var expected = "a";
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
        
        [Test]
        public void Test_Case4()
        {
            var input = "bb";
            var expected = "bb";
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
        
        [Test]
        public void Test_Case5()
        {
            var input = string.Empty;
            var expected = string.Empty;
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
        
        [Test]
        public void Test_Case6()
        {
            var input = "asdfghjklkjhgfdsaaag";
            var expected = "asdfghjklkjhgfdsa";
            Assert.AreEqual(expected, new Solution().LongestPalindrome(input));
        }
    }
}