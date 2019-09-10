using LeetCode.AddTwoNumbers;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class TestAddTwoNumbers
    {
        [Test]
        public void Test_Default()
        {
            var solution = new Solution();
            var input1 = new[] {2, 4, 3}.GetListNode();
            var input2 = new[] {5, 6, 4}.GetListNode();

            var result = solution.AddTwoNumbers(input1, input2);
            var expectOutput = new[] {7, 0, 8}.GetListNode();

            Assert.AreEqual(expectOutput, result);
        }


        [Test]
        public void Test_Case1()
        {
            var solution = new Solution();
            var input1 = new[] {8, 1}.GetListNode();
            var input2 = new[] {0}.GetListNode();

            var result = solution.AddTwoNumbers(input1, input2);
            var expectOutput = new[] {8, 1}.GetListNode();

            Assert.AreEqual(expectOutput, result);
        }
        
        
        [Test]
        public void Test_Case2()
        {
            var solution = new Solution();
            var input1 = new[] {1}.GetListNode();
            var input2 = new[] {9, 9}.GetListNode();

            var result = solution.AddTwoNumbers(input1, input2);
            var expectOutput = new[] {0, 0, 1}.GetListNode();

            Assert.AreEqual(expectOutput, result);
        }
        
        [Test]
        public void Test_Case3()
        {
            var solution = new Solution();
            var input1 = new[] {9,9,9,9,9,9,9,9,9,9}.GetListNode();
            var input2 = new[] {9,9,9,9,9,9,9,9,9,9}.GetListNode();

            var result = solution.AddTwoNumbers(input1, input2);
            var expectOutput = new[] {8,9,9,9,9,9,9,9,9,9,1}.GetListNode();

            Assert.AreEqual(expectOutput, result);
        }
    }
}