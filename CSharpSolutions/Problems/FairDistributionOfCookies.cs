using CSharpSolutions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems
{
    /// <summary>
    /// You are given an integer array cookies, where cookies[i] denotes the number of cookies in the ith bag. You are also given an integer k that denotes the number of children to distribute all the bags of cookies to. All the cookies in the same bag must go to the same child and cannot be split up.
    /// The unfairness of a distribution is defined as the maximum total cookies obtained by a single child in the distribution.
    /// Return the minimum unfairness of all distributions.
    /// 
    /// Constraints:
    /// 2 <= cookies.length <= 8
    /// 1 <= cookies[i] <= 105
    /// 2 <= k <= cookies.length
    /// </summary>
    public class FairDistributionOfCookies : Solution
    {
        public static int DistributeCookies(int[] cookies, int k)
        {

            // In order to complete this a back tracking algorithm should be used to get the set of sets from cookies

            List<List<int>> subsets = new List<List<int>>();
            List<int> input = cookies.ToList();

            FindSubsets(subsets, input, new List<int>(), 0);

            return 0;

        }

        public static void FindSubsets(List<List<int>> subsets, List<int> nums, List<int> output, int index) {
            
            if (index == nums.Count)
            {
                subsets.Add(output);
                return;
            }

            // This call if proceeding down the tree without the current index value
            FindSubsets(subsets, nums, new List<int>(output), index + 1);
            output.Add(nums[index]);
            // This call is proceeding down the tree with the current index value
            FindSubsets(subsets, nums, new List<int>(output), index + 1);
        }
    }
}
