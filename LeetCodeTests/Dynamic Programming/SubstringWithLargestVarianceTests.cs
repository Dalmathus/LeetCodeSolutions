using CSharpSolutions.Problems.Dynamic_Programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Dynamic_Programming
{
    [TestClass]
    public class SubstringWithLargestVarianceTests
    {

        [TestMethod]
        public void Example1()
        {
            string s = "aababbb";
            SubstringWithLargestVariance swlv = new SubstringWithLargestVariance();
            int result = swlv.LargestVariance(s);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Example2()
        {
            string s = "abcde";
            SubstringWithLargestVariance swlv = new SubstringWithLargestVariance();
            int result = swlv.LargestVariance(s);
            Assert.AreEqual(0, result);
        }

    }
}
