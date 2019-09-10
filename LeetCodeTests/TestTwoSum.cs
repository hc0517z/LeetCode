using LeetCode.TwoSum;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestTwoSum
    {
        [Test]
        public void Test_Default()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {2, 7, 11, 15}, 9);
            CollectionAssert.AreEqual(new[] {0, 1}, result);
        }
        
        [Test]
        public void Test_Case1()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {0, 4, 3, 0}, 0);
            CollectionAssert.AreEqual(new[] {0, 3}, result);
        }
        
        [Test]
        public void Test_Case2()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {-1, -2, -3, -4, -5}, -8);
            CollectionAssert.AreEqual(new[] {2, 4}, result);
        }
    }
}