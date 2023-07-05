using CSharpSolutions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems
{   
    public class LngSubAryAftDelOneEle : Solution
    {
        /// <summary>
        /// Given a binary array nums, you should delete one element from it.
        /// Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LongestSubarray(int[] nums)
        {
            int currentMax = 0;
            int leftConcurrent = 0;
            int rightConcurrent = 0;
            bool gapFound = false;

            // Idea
            // Start assuming we are filling the left side of the count. 
            // Count consecutive 1's until we get to a 0
            // If the value after that 0 is a 1 then start counting left
            // once we hit a zero sum the total of the left + the total of the right
            // set the right to the left
            // repeat from 3 until end

            if (!nums.Contains(0)) return nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    rightConcurrent++;
                }

                if (nums[i] == 0)
                {
                    gapFound = true;
                    currentMax = Math.Max(currentMax, leftConcurrent + rightConcurrent);
                    leftConcurrent = rightConcurrent;
                    rightConcurrent = 0;
                }
            }

            currentMax = Math.Max(currentMax, leftConcurrent + rightConcurrent);

            // if its all 1's we return leftConcurrent - 1 because we have to delete one :(
            if (!gapFound) return nums.Length - 1;
            // In the real world I would have done if (!nums.Contains(0)) return nums.Length - 1 but its twice as slow technically

            // You could techincally write an edge case for when you have all 1's until after the mid point of the array and then hit a double 00 you know you can't get better so just return current.
            // I did that but leetcode didnt have it in their judge case so it just slowed performance down doing the additional check every time to see if we have passed half way yet 

            // if its all 0's we leave the loop because we havne't started counting left yet and just return 0
            return currentMax;       
        }
    }
}
