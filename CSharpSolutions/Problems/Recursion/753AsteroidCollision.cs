using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.Recursion
{
    public class _753AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            return RecursiveCollision(asteroids.ToList()).ToArray();
        }

        public List<int> RecursiveCollision(List<int> asteroids) 
        {

            // If I have 0 or 1 asteroids
            // If I have only left asteroids
            // If I have only right asteroids -- might retire this for the check collision
            if (asteroids.Count <= 1 || asteroids.Count(x => x > 0) == 0 || asteroids.Count(x => x < 0) == 0)
            {
                return asteroids;
            }

            int count = asteroids.Count;

            for (int i = 0; i < asteroids.Count - 1; i++)
            {
                // if we are going to collide, check collision
                if (asteroids[i] > 0 && asteroids[i + 1] < 0)
                {
                    if (Math.Abs(asteroids[i]) < Math.Abs(asteroids[i + 1]))
                    {
                        asteroids.RemoveAt(i);
                        i--;
                        continue;
                    }

                    if (Math.Abs(asteroids[i]) > Math.Abs(asteroids[i + 1]))
                    {
                        asteroids.RemoveAt(i + 1);
                        i--;
                        continue;
                    }

                    asteroids.RemoveRange(i, 2);
                    i = i - 2;
                }
            }

            // We didn't collide during this iteration, asteroids are exclusively moving away from each other
            if (count == asteroids.Count) return asteroids;

            return RecursiveCollision(asteroids);
        }
    }
}
