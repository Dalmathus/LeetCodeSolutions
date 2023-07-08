using CSharpSolutions.Problems.Backtracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Backtracking
{
    [TestClass]
    public class FairDistributionOfCookiesTests
    {
        [TestMethod]
        public void Example1()
        {
            int[] cookies = new int[] { 8, 15, 10, 20, 8 };
            int k = 2;

            int result = FairDistributionOfCookies.DistributeCookies(cookies, k);

            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void Example2()
        {
            int[] cookies = new int[] { 6, 1, 3, 2, 2, 4, 1, 2 };
            int k = 3;

            int result = FairDistributionOfCookies.DistributeCookies(cookies, k);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Example3()
        {
            int[] cookies = new int[] { 1, 2, 3 };
            int k = 3;

            int result = FairDistributionOfCookies.DistributeCookies(cookies, k);

            Assert.AreEqual(3, result);
        }
    }
}
