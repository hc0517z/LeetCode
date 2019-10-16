using LeetCode.IntegerToRoman;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestIntegerToRoman
    {
        [Test]
        public void Test_Case1()
        {
            var input = 3;
            var output = "III";
            
            Assert.AreEqual(output, new Solution().IntToRoman(input));
        }
        
        [Test]
        public void Test_Case2()
        {
            var input = 4;
            var output = "IV";
            
            Assert.AreEqual(output, new Solution().IntToRoman(input));
        }
        
        [Test]
        public void Test_Case3()
        {
            var input = 9;
            var output = "IX";
            
            Assert.AreEqual(output, new Solution().IntToRoman(input));
        }
        
        [Test]
        public void Test_Case4()
        {
            var input = 58;
            var output = "LVIII";
            
            Assert.AreEqual(output, new Solution().IntToRoman(input));
        }
        
        [Test]
        public void Test_Case5()
        {
            var input = 1994;
            var output = "MCMXCIV";
            
            Assert.AreEqual(output, new Solution().IntToRoman(input));
        }
    }
}