using CSharpSolutions.Problems.BFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.BFS
{
    [TestClass]
    public class FindEventualStatesTests
    {
        [TestMethod]
        public void Example1()
        {


            int[][] graph = { 
                new[] { 1, 2 }, 
                new[] { 2, 3 },
                new[] { 5 },
                new[] { 0 }, 
                new[] { 5 },
                Array.Empty<int>(),
                Array.Empty<int>()
            };

            FindEventualSafeStates fs = new FindEventualSafeStates();
            fs.EventualSafeNodes(graph);

        }

        [TestMethod]
        public void Example2()
        {


            int[][] graph = {
                new[] { 1, 2, 3, 4 },
                new[] { 1, 2 },
                new[] { 3, 4 },
                new[] { 0, 4 },
                Array.Empty<int>()
            };

            FindEventualSafeStates fs = new FindEventualSafeStates();
            fs.EventualSafeNodes(graph);

        }
    }
}
