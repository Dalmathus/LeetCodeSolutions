using CSharpSolutions.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    [TestClass]
    public class MinimumSizeSubarraySumWorkingTests
    {
        [TestMethod]
        public void Example1()
        {
            int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };
            int target = 7;

            int result = MinimumSubarraySumWorking.MinSubArrayLen(target, nums);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Example2()
        {
            int[] nums = new int[] { 1, 4, 4 };
            int target = 4;

            int result = MinimumSubarraySumWorking.MinSubArrayLen(target, nums);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Example3()
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            int target = 11;

            int result = MinimumSubarraySumWorking.MinSubArrayLen(target, nums);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Example4()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int target = 15;

            int result = MinimumSubarraySumWorking.MinSubArrayLen(target, nums);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Example5()
        {
            int[] nums = new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 };
            int target = 213;

            int result = MinimumSubarraySumWorking.MinSubArrayLen(target, nums);

            Assert.AreEqual(8, result);
        }
    }
}
