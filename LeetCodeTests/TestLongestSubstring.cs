using LeetCode.LongestSubstring;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestLongestSubstring
    {
        [Test]
        public void Test_Default()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void Test_Case1()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Test_Case2()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void Test_Case3()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring(" ");
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Test_Case4()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("aab");
            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void Test_Case5()
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring("dvdf");
            Assert.AreEqual(3, result);
        }
    }
}