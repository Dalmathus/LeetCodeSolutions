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
            List<int> input = cookies.ToList();
            List<int> children = new List<int>();

            for (int i = 0; i < k; i++)
            {
                children.Add(0);
            }

            int test = BacktrackCookies(input, children, 0);

            return test;
        }

        public static int BacktrackCookies(List<int> input, List<int> children, int index) {
            
            // If we are at the bottom of the tree bail out
            if (index == input.Count)
            {
                return children.Max();
            }

            int result = int.MaxValue;

            for (int i = 0; i < children.Count; i++)
            {                  
                children[i] += input[index];
                result = Math.Min(result, BacktrackCookies(input, children, index + 1));
                children[i] -= input[index];
            }

            return result;
        }
    }
}
