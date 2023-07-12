using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.BFS
{
    public class FindEventualSafeStates
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            // Insert all nodes into a master list
            List<int> masterList = Enumerable.Range(0, graph.Length).ToList(); 
            
            // Create a result list
            List<int> terminalList = new List<int>();
            // Create a bad node list
            List<int> badList = new List<int>();

            // Find all terminal nodes save their indexes in a terminal node list, remove these nodes from the master list
            foreach(int i in masterList)
            {
                if (graph[i].Length == 0)
                {
                    terminalList.Add(i);
                }
            }

            masterList = masterList.Except(terminalList).ToList();

            // Take a count of elements in the list
            int startCount = masterList.Count;
            
            // Just so the first while loop doesnt break set it to a pointless number that cannot be startCount
            int endCount = startCount + 1;

            // If at this point we have no terminal nodes return empty list
            if (startCount == 0) return terminalList;

            // Loop through the master list until the list is empty or master list count is the same at the start of an iteration as it is at the end of an iteration
            while(masterList.Count > 0 && startCount != endCount)
            {
                startCount = masterList.Count;

                for(int i = 0; i < startCount; i++)
                {
                    // if the node links to itself add it to the bad list, remove from the master list
                    // if the node links to a node in the bad list add it to the bad list, remove from the master list 
                    if (graph[masterList[i]].Contains(masterList[i]) || badList.Contains(masterList[i]))
                    {
                        badList.Add(masterList[i]);                       
                        continue;
                    }

                    // If the node only links to a terminal node add it to the list of terminal nodes, remove from the master list
                    if (graph[masterList[i]].All(g => terminalList.Contains(g)))
                    {
                        terminalList.Add(masterList[i]);
                        continue;
                    }

                    // If the node links to an index not in the terminal node list and not in the bad list skip it
                }

                // Remove all bad and terminal nodes from consideration in further loops
                masterList = masterList.Except(terminalList).ToList();
                masterList = masterList.Except(badList).ToList();

                endCount = masterList.Count;
            }        

            // return the list of ints in ascending order
            terminalList.Sort();

            return terminalList;
        }
    }
}

