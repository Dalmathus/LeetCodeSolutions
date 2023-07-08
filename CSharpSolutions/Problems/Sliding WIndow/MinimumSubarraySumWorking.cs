using CSharpSolutions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems
{
    public class MinimumSubarraySumWorking : Solution
    {
        // Sliding Window Algorithm
        public static int MinSubArrayLen(int target, int[] nums)
        {
            // Want to check if this is faster
            if (nums.Sum() < target) return 0;

            int leftPointer = 0;
            int runningTotal = 0;
            
            // Set the fallback value to an impossibly high number
            int fallbackValue = int.MaxValue;
            
            for (int rightPointer = 0; rightPointer < nums.Length; rightPointer++)
            {
                // Start counting from left to right summing as you go
                runningTotal += nums[rightPointer];

                // Once your sum has hit above the target we enter the loop
                while (runningTotal >= target)
                {
                    // The loop is going to check how big our window currently is and store it as our current 'smallest' number of consecutive values over target
                    fallbackValue = Math.Min(fallbackValue, rightPointer - leftPointer + 1);
                    // Then we start pulling the other window to overlap, we take away the left most number (the start of our consecutive values) and see if we are still over target 
                    runningTotal -= nums[leftPointer];
                    // move the left point over to get ready to check the next number
                    leftPointer++;
                }
            }

            // send back the result! 
            return fallbackValue != int.MaxValue ? fallbackValue : 0;
        }
    }
}
