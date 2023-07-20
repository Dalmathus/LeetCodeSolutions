using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Greedy
{
    public class CourseSchedule
    {

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {

            // Intuition

            // Create a list of every course a student can currently do
            List<int> eligibleCourses = new List<int>();

            // Create a list of prereqs
            List<int> preReqs = new List<int>();

            // Create a list of postreqs
            List<int> postReqs = new List<int>();

            if (prerequisites.Length == 0) { return false; }

            foreach (int[] array in prerequisites)
            {
                preReqs.Add(array[1]);
                postReqs.Add(array[0]);
            }

            // Check if there are literally enough courses that you could take
            if (postReqs.Union(preReqs).ToList().Count < numCourses - 1) return false;

            // Do a first loop of the list to find all base eligible courses
            eligibleCourses = preReqs.Except(postReqs).ToList();

            // If no courses can be started then heavens to betsy its not dang possible to go to this school
            if (eligibleCourses.Count == 0) { return false; }

            while (eligibleCourses.Count <= numCourses)
            {
                return true;
            }


            return true;
        }
    }
}
