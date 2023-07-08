using CSharpSolutions.Problems.LINQ;

namespace LeetCodeTests.LINQ
{
    [TestClass]
    public class SingleNumber2Tests
    {
        [TestMethod]
        public void Example1()
        {
            int[] nums = new int[] { 2, 2, 3, 2 };

            int result = SingleNumber2.SingleNumber(nums);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Example2()
        {
            int[] nums = new int[] { 0, 1, 0, 1, 0, 1, 99 };

            int result = SingleNumber2.SingleNumber(nums);

            Assert.AreEqual(99, result);
        }

    }
}