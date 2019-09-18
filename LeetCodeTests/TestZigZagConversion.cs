using LeetCode.ZigZagConversion;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestZigZagConversion
    {
        [Test]
        public void Test_Case1()
        {
            var inputStr = "PAYPALISHIRING";
            var inputNumRows = 3;

            var expected = "PAHNAPLSIIGYIR";
            
            Assert.AreEqual(expected, new Solution().Convert(inputStr, inputNumRows));
        }
        
        [Test]
        public void Test_Case2()
        {
            var inputStr = "AB";
            var inputNumRows = 1;

            var expected = "AB";
            
            Assert.AreEqual(expected, new Solution().Convert(inputStr, inputNumRows));
        }
    }
}