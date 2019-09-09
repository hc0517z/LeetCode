using System;
using LeetCode._1_TwoSum;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_TwoSum()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solution(new[] {2, 7, 11, 15}, 9);
            CollectionAssert.AreEqual(new[] {0, 1}, result);
        }
        
        [Test]
        public void Test_TwoSum_Case1()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solution(new[] {0, 4, 3, 0}, 0);
            CollectionAssert.AreEqual(new[] {0, 3}, result);
        }
        
        [Test]
        public void Test_TwoSum_Case2()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solution(new[] {-1, -2, -3, -4, -5}, -8);
            CollectionAssert.AreEqual(new[] {2, 4}, result);
        }
    }
}