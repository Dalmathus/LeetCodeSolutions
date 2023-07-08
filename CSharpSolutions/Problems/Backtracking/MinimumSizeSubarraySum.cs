using CSharpSolutions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpSolutions.Problems.Backtracking
{
    public class MinimumSizeSubarraySum : Solution
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            List<List<int>> subset = new List<List<int>>();

            if (nums.Sum() < target) return 0;

            BuildSubset(subset, target, new List<int>(), nums.ToList(), 0);

            DeleteInvalidSubarrays(subset, nums);

            return subset.Min(x => x.Count);
        }

        public static void BuildSubset(List<List<int>> subset, int target, List<int> output, List<int> nums, int index)
        {

            if (output.Sum() >= target)
            {
                subset.Add(new List<int>(output));
                return;
            }

            if (index == nums.Count)
            {
                return;
            }

            BuildSubset(subset, target, new List<int>(output), nums, index + 1);

            output.Add(nums[index]);
            BuildSubset(subset, target, new List<int>(output), nums, index + 1);
        }

        public static void DeleteInvalidSubarrays(List<List<int>> subset, int[] nums)
        {
            List<int> masterArray = new List<int>(nums);

            int n = masterArray.Count;

            for (int listNum = subset.Count - 1; listNum >= 0; listNum--)
            {
                int m = subset[listNum].Count;
                bool keepSubset = false;
                int i = 0, j = 0;

                while (i < n && j < m)
                {
                    if (masterArray[i] == subset[listNum][j])
                    {
                        i++;
                        j++;

                        if (j == m)
                            keepSubset = true;
                    }
                    else
                    {
                        i = i - j + 1;
                        j = 0;
                    }
                }

                if (!keepSubset)
                {
                    subset.RemoveAt(listNum);
                }
            }
        }
    }
}
