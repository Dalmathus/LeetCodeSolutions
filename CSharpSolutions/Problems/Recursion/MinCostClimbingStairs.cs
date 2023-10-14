using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Recursion
{
    public class MinCostClimbingStairs
    {

        public int minCost = Int32.MaxValue;

        public int MinCostClimbingStairsProblem(int[] cost)
        {

            int n = cost.Length;

            for (int i = 2; i < cost.Length; i++)
            {
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            }

            return Math.Min(cost[n - 1], cost[n - 2]);
        }
    }
}
