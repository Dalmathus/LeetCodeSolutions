using CSharpSolutions.Problems.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Recursion
{
    [TestClass]
    public class MinCostClimbingStairsTests
    {
        [TestMethod]
        public void Example1()
        {

            MinCostClimbingStairs prob = new MinCostClimbingStairs();

            int[] input = new int[] { 10, 15, 25 };

            int result = prob.MinCostClimbingStairsProblem(input);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Example2()
        {

            MinCostClimbingStairs prob = new MinCostClimbingStairs();

            int[] input = new int[] { 0, 2, 2, 1 };

            int result = prob.MinCostClimbingStairsProblem(input);

            Assert.AreEqual(2, result);
        }

    }
}
