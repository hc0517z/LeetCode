using LeetCode.MedianOfTwoSortedArrays;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestMedianOfTwoSortedArrays
    {
        [Test]
        public void Test_Default()
        {
            var solution = new Solution();
            var input1 = new[] {1, 3};
            var input2 = new[] {2};
            var expected = 2.0;

            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case1()
        {
            var solution = new Solution();
            var input1 = new[] {1, 2};
            var input2 = new[] {3, 4};
            var expected = 2.5;

            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case2()
        {
            var solution = new Solution();
            var input1 = new int[0];
            var input2 = new[] {1};
            var expected = 1;

            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case3()
        {
            var solution = new Solution();
            var input1 = new[] {3};
            var input2 = new[] {-2, -1};
            var expected = -1.0;

            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case4()
        {
            var solution = new Solution();
            var input1 = new[] {1};
            var input2 = new[] {1};
            var expected = 1.0;

            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case5()
        {
            var solution = new Solution();
            var input1 = new[] {1,1,1,1,1,1,1,1,1,1,4,4};
            var input2 = new[] {1,3,4,4,4,4,4,4,4,4,4};
            var expected = 3.0;
            
            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Case6()
        {
            var solution = new Solution();
            var input1 = new[] {1,1};
            var input2 = new[] {1,2};
            var expected = 1;
            
            var result = solution.FindMedianSortedArrays(input1, input2);
            Assert.AreEqual(expected, result);
        }
    }
}