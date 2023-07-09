using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Queue
{
    public class Dota2Senate
    {
        public string PredictPartyVictory(string senate)
        {
            List<char> votes = senate.ToList();

            int rDeny = 0;
            int dDeny = 0;

            while (true)
            {   
                for (int i = 0; i < votes.Count; i++) {
                    if (votes[i] == 'R' && rDeny == 0)
                    {
                        dDeny++;
                        continue;
                    }

                    if (votes[i] == 'R' && rDeny > 0)
                    {
                        votes.RemoveAt(i);
                        i--;
                        rDeny--;
                        continue;
                    }

                    if (votes[i] == 'D' && dDeny == 0)
                    {
                        rDeny++;
                        continue;
                    }

                    if (votes[i] == 'D' && dDeny > 0)
                    {
                        votes.RemoveAt(i);
                        i--;
                        dDeny--;
                        continue;
                    }
                }

                if (!votes.Contains('R')) return "Dire";
                if (!votes.Contains('D')) return "Radiant";
            }
        }
    }
}
