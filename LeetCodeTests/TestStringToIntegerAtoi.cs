using LeetCode.StringToIntegerAtoi;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestStringToIntegerAtoi
    {
        [Test]
        public void Test_Case1()
        {
            var input = "42";
            var output = 42;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case2()
        {
            var input = "   -42";
            var output = -42;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case3()
        {
            var input = "4193 with words";
            var output = 4193;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case4()
        {
            var input = "words and 987";
            var output = 0;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case5()
        {
            var input = "-91283472332";
            var output = -2147483648;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case6()
        {
            var input = "3.14159";
            var output = 3;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case7()
        {
            var input = "  0000000000012345678";
            var output = 12345678;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case8()
        {
            var input = "9223372036854775808";
            var output = 2147483647;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case9()
        {
            var input = "+";
            var output = 0;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
        
        [Test]
        public void Test_Case10()
        {
            var input = "+-2";
            var output = 0;
            
            Assert.AreEqual(output, new Solution().MyAtoi(input));
        }
    }
}