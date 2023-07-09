using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Dynamic_Programming
{
    public class SubstringWithLargestVariance
    {
        public int LargestVariance(string s)
        {
            int global_max = 0;
            int major_count, minor_count, rest_minor;

            char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char major, minor;

            // Letters in the English alphabet
            for (int i = 0; i < 26; i++)
            {
                // Don't bother if the character doesn't exist
                if (!s.Contains(alphabet[i])) continue;        
               
                major = alphabet[i];

                for (int j = 0; j < 26; j++)
                {
                    // Reset the major and minor count to 0 at the start of a new substring
                    major_count = 0;
                    minor_count = 0;

                    // We only care about distinct pairs
                    if (i == j) continue;

                    // Don't bother if the character doesn't exist
                    if (!s.Contains(alphabet[j])) continue;
                    minor = alphabet[j];
                    
                    rest_minor = s.Count(x => x == minor);
                    
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (s[k] == major) major_count++;
                        if (s[k] == minor)
                        {
                            minor_count++;
                            rest_minor--;
                        }

                        if (minor_count > 0) global_max = Math.Max(global_max, major_count - minor_count);

                        if(major_count - minor_count < 0 && rest_minor > 0)
                        {
                            major_count = 0; 
                            minor_count = 0;
                        }
                    }
                }
            }
            return global_max;
        }
    }
}
