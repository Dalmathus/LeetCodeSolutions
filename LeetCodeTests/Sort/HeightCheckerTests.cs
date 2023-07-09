using CSharpSolutions.Problems.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Sort
{
    [TestClass]
    public class HeightCheckerTests
    {
        [TestMethod]
        public void Example1()
        {
            HeightCheckers hs = new HeightCheckers();
            int[] heights = { 1, 1, 4, 2, 1, 3 };
            int results = hs.HeightChecker(heights);
            Assert.AreEqual(3, results);
        }
    }
}
