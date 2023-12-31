﻿using CSharpSolutions.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    [TestClass]
    public class MaximizeTheConfusionOfAnExamWindowTests
    {
        [TestMethod]
        public void Example1()
        {
            string answerKey = "TTFF";
            int k = 2;

            MaximizeTheConfusionOfAnExamWindow test = new MaximizeTheConfusionOfAnExamWindow();

            int result = test.MaxConsecutiveAnswers(answerKey, k);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Example2()
        {
            string answerKey = "TFFT";
            int k = 1;

            MaximizeTheConfusionOfAnExamWindow test = new MaximizeTheConfusionOfAnExamWindow();

            int result = test.MaxConsecutiveAnswers(answerKey, k);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Example3()
        {
            string answerKey = "TTFTTFTT";
            int k = 1;

            MaximizeTheConfusionOfAnExamWindow test = new MaximizeTheConfusionOfAnExamWindow();

            int result = test.MaxConsecutiveAnswers(answerKey, k);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Example4()
        {
            string answerKey = "FFFTTFTTFT";
            int k = 3;

            MaximizeTheConfusionOfAnExamWindow test = new MaximizeTheConfusionOfAnExamWindow();

            int result = test.MaxConsecutiveAnswers(answerKey, k);

            Assert.AreEqual(8, result);
        }
    }
}
