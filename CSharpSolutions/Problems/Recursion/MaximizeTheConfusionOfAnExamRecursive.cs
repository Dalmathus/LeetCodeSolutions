using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Recursive
{
    public class MaximizeTheConfusionOfAnExamRecursive
    {
        public int MaxConsecutiveAnswers(string answerKey, int k)
        {
            // Turn the key into an array of characters
            char[] answerSequence = answerKey.ToArray();

            // Set the current maximum value to 0
            int currentMaximum = 0;

            for (int currentPoint = 0; currentPoint < answerSequence.Length; currentPoint++)
            {
                // Check how far we can go with our current character
                currentMaximum = Math.Max(currentMaximum, ScanAhead(answerSequence, answerSequence[currentPoint], k, currentPoint));

                // Check how far we can go with the opposite character
                currentMaximum = Math.Max(currentMaximum, ScanAhead(answerSequence, answerSequence[currentPoint] == 'T' ? 'F' : 'T', k, currentPoint));
            }

            // send back the result! 
            return currentMaximum;
        }

        public int ScanAhead(char[] answerKey, char testChar, int allowance, int index)
        {
            if (index == answerKey.Length)
            {
                return 0;
            }

            if (allowance == 0 && answerKey[index] != testChar)
            {
                return 0;
            }

            if (allowance > 0 && answerKey[index] != testChar)
            {
                allowance--;
            }

            return 1 + ScanAhead(answerKey, testChar, allowance, index + 1);
        }
    }
}
