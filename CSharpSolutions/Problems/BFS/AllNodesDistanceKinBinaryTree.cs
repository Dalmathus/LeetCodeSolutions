using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.BFS
{
    public class AllNodesDistanceKinBinaryTree
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            List<int> result = new List<int>();
            bool searching = true;

            Dictionary<TreeNode, List<TreeNode>> graph = new Dictionary<TreeNode, List<TreeNode>>();

            BuildGraph(root, null, graph);

            Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();

            queue.Enqueue(new Tuple<TreeNode, int>(target, 0));
            List<TreeNode> visited = new List<TreeNode>();

            while (queue.Any()) {

                Tuple<TreeNode, int> tuple = queue.Dequeue();

                TreeNode node = tuple.Item1;
                int distance = tuple.Item2;

                if (visited.Contains(node)) continue;
                visited.Add(node);

                if (k == distance)
                {
                    result.Add(node.val);
                }        
                else if (distance < k)
                {
                    foreach (TreeNode children in graph[node]) {
                        queue.Enqueue(new Tuple<TreeNode, int>(children, distance + 1));
                    }
                }

            }

            return result;
        }

        public void BuildGraph(TreeNode node, TreeNode parent, Dictionary<TreeNode, List<TreeNode>> graph)
        {                   

            if (node == null)
            {
                return;
            }

            List<TreeNode> nodes = new List<TreeNode>();
            graph.Add(node, nodes);

            if (parent != null)
            {
                graph[node].Add(parent);
            }

            if (node.left != null)
            {
                graph[node].Add(node.left);
                BuildGraph(node.left, node, graph);
            }

            if (node.right != null)
            {
                graph[node].Add(node.right);
                BuildGraph(node.right, node, graph);
            }
        }
    }
}
