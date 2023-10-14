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

            int zeroCost = recursiveSearch(cost, 0, 0);
            int oneCost = recursiveSearch(cost, 1, 0);
            return minCost;
        }

        public int recursiveSearch(int[] stairs, int index, int cost)
        {

            cost += stairs[index];

            if (cost >= minCost) return Int32.MaxValue;

            if (index + 2 >= stairs.Length)
            {
                if (cost < minCost) minCost = cost;
                return cost;
            }

            recursiveSearch(stairs, index + 1, cost);
            recursiveSearch(stairs, index + 2, cost);
            return -1;
        }

    }
}
