using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Sort
{
    public class HeightCheckers
    {
        public int HeightChecker(int[] heights)
        {
            List<int> sortedHeights = new List<int>(heights);
            sortedHeights.Sort();
            int mismatchingIndexes = 0;

            for (int i = 0; i < sortedHeights.Count; i++)
            {
                if (heights[i] != sortedHeights[i]) mismatchingIndexes++;
            }
            
            return mismatchingIndexes;
        }
    }
}
