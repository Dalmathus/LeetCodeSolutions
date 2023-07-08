using CSharpSolutions.Problems.Greedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Greedy
{
    [TestClass]
    public class PutMarblesInBagTests
    {
        [TestMethod]
        public void Example1()
        {
            int[] weights = { 1, 3, 5, 1 };
            int k = 2;

            PutMarblesInBag b = new PutMarblesInBag();
            long result = b.PutMarbles(weights, k);
            Assert.AreEqual(4, result);
        }
    }
}
