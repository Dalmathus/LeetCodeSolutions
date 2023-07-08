using CSharpSolutions.Base;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.LINQ
{
    public class SingleNumber2 : Solution
    {
        /// <summary>
        /// Problem number 137 https://leetcode.com/problems/single-number-ii/
        /// 
        /// Given an integer array nums where every element appears three times except for one, which appears exactly once. Find the single element and return it.
        /// You must implement a solution with a linear runtime complexity and use only constant extra space.
        /// Example 1:
        /// Input: nums = [2,2,3,2]
        /// Output: 3
        /// 
        /// Example 2:
        /// Input: nums = [0,1,0,1,0,1,99]
        /// Output: 99
        /// 
        /// Constraints:
        /// 1 <= nums.length <= 3 * 10^4
        /// -2^31 <= nums[i] <= 2^31 - 1
        /// Each element in nums appears exactly three times except for one element which appears once.
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            // At most we have 30k entries so lets just write an iterable comparison      
            // Explanation, the Group by x => x means its just referencing its only element
            // This will create a group and count for each distinct variable
            // Where(g => g.Count() == 1 returns only results where the count value is 1
            // ToList() turns it into a list, easy index retrieval later
            var countList = nums.GroupBy(x => x).Where(g => g.Count() == 1).ToList();
            return countList[0].Key;


            // Solution results at submit time

            // 50.96% for runtime
            // 7.64% for memory - 41.2mb used, best case was 39.2mb

            // The solution could be improved by changing to a byte checking solution but I think the above is easy to read, understand and the difference is neglible (2mb)
            // The ideal solution is only for leetcode not for industry
        }

    }
}
