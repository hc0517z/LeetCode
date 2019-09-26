using LeetCode.ContainerWithMostWater;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestContainerWithMostWater
    {
        [Test]
        public void Test_Case1()
        {
            var input = new[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            var output = 49;
            
            Assert.AreEqual(output, new Solution().MaxArea(input));
        }
    }
}