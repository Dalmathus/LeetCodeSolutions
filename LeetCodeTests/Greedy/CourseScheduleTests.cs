using CSharpSolutions.Problems.BFS;
using CSharpSolutions.Problems.Greedy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Greedy
{
    [TestClass]
    public class CourseScheduleTests
    {
        [TestMethod]
        public void Example1()
        {
            bool result;

            int[][] graph = {
                new[] { 1, 0 },
                new[] { 0, 1 }
            };

            CourseSchedule cs = new CourseSchedule();

            result = cs.CanFinish(2, graph);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Example2()
        {
            bool result;

            int[][] graph = {
                new[] { 1, 0 }
            };

            CourseSchedule cs = new CourseSchedule();

            result = cs.CanFinish(2, graph);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Example3()
        {
            bool result;

            int[][] graph = new int[0][];

            CourseSchedule cs = new CourseSchedule();

            result = cs.CanFinish(1, graph);

            Assert.AreEqual(false, result);

        }
    }
}
