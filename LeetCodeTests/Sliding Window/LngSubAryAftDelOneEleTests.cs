using CSharpSolutions.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    [TestClass]
    public class LngSubAryAftDelOneEleTests
    {
        [TestMethod]
        public void Example1()
        {
            int[] nums = new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 };

            int result = LngSubAryAftDelOneEle.LongestSubarray(nums);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Example2()
        {
            int[] nums = new int[] { 1, 1, 0, 1 };

            int result = LngSubAryAftDelOneEle.LongestSubarray(nums);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Example3()
        {
            int[] nums = new int[] { 1, 1, 1 };


            int result = LngSubAryAftDelOneEle.LongestSubarray(nums);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Example4()
        {
            int[] nums = new int[] { 0, 0, 0 };

            int result = LngSubAryAftDelOneEle.LongestSubarray(nums);

            Assert.AreEqual(0, result);
        }

    }
}
