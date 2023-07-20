using CSharpSolutions.Problems.Recursion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Recursion
{
    [TestClass]
    public class AsteroidCollisionTests
    {
        [TestMethod]
        public void Example1()
        {
            int[] asteroids = new int[] {5, 10, -5 };
            int[] result;

            _753AsteroidCollision _753AsteroidCollision = new _753AsteroidCollision();

            result = _753AsteroidCollision.AsteroidCollision(asteroids);

            var object1Json = JsonConvert.SerializeObject(new int[] { 5, 10 });
            var object2Json = JsonConvert.SerializeObject(result);

            Assert.AreEqual(object1Json, object2Json);
        }

        [TestMethod]
        public void Example2()
        {
            int[] asteroids = new int[] { -2, -1, 1, 2 };
            int[] result;

            _753AsteroidCollision _753AsteroidCollision = new _753AsteroidCollision();

            result = _753AsteroidCollision.AsteroidCollision(asteroids);

            var object1Json = JsonConvert.SerializeObject(new int[] { -2, -1, 1, 2 });
            var object2Json = JsonConvert.SerializeObject(result);

            Assert.AreEqual(object1Json, object2Json);
        }

    }
}
