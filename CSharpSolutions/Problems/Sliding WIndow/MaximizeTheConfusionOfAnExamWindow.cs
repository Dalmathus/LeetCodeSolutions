using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems
{
    public class MaximizeTheConfusionOfAnExamWindow
    {
        public int MaxConsecutiveAnswers(string answerKey, int k)
        {
            // Turn the key into an array of characters
            char[] answerSequence = answerKey.ToArray();

            // Set the current maximum value to 0
            int leftPointer = 0;
            int TCount = 0;
            int FCount = 0;

            for (int currentPoint = 0; currentPoint < answerSequence.Length; currentPoint++)
            {
                // Increment the appropriate counter
                if (answerSequence[currentPoint] == 'T') TCount++;
                else if (answerSequence[currentPoint] == 'F') FCount++;

                // Check if we break constraints
                if (Math.Min(TCount, FCount) > k)
                {
                    if (answerSequence[leftPointer] == 'T') TCount--;
                    else if (answerSequence[leftPointer] == 'F') FCount--;
                    leftPointer++;
                }
            }

            // send back the result! 
            return TCount + FCount;
        }

    }
}
