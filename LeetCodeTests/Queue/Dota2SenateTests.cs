using CSharpSolutions.Problems.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.NewFolder
{
    [TestClass]
    public class Dota2SenateTests
    {
        [TestMethod]
        public void Example1()
        {
            Dota2Senate ds = new Dota2Senate();
            string result = ds.PredictPartyVictory("RD");

            Assert.AreEqual("Radiant", result);
        }

        [TestMethod]
        public void Example2()
        {
            Dota2Senate ds = new Dota2Senate();
            string result = ds.PredictPartyVictory("RDD");

            Assert.AreEqual("Dire", result);
        }

        [TestMethod]
        public void Example3()
        {
            Dota2Senate ds = new Dota2Senate();
            string result = ds.PredictPartyVictory("RRR");

            Assert.AreEqual("Radiant", result);
        }
    }
}
