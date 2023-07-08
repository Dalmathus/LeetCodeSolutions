using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems
{
    public class PutMarblesInBag
    {
        public long PutMarbles(int[] weights, int k)
        {
            int length = weights.Length;
            long min, max;

            List<int> borders = new List<int>();

            for (int i = 1; i < length; i++)
            {
                borders.Add(weights[i] + weights[i - 1]);
            }

            borders.Sort();

            min = weights[0] + weights[length - 1];
            max = weights[0] + weights[length - 1];

            for (int i = length - k; i < length - 1; i++)
            {
                max += borders[i];
            }

            for (int i = 0; i < k - 1; i++)
            {
                min += borders[i];
            }

            return max - min;
        }
    }
}
