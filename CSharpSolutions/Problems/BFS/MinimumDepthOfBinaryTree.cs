using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Problems.BFS
{
    public class MinimumDepthOfBinaryTree
    {

        /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

        public int MinDepth(TreeNode root)
        { 
            List<Tuple<int, TreeNode>> children = new List<Tuple<int, TreeNode>>();
            
            // Fail case for no tree
            if (root == null) return 0;

            children.Add(new Tuple<int, TreeNode>(1, root));
            
            while (children.Count > 0)
            {
                // get current node out of the list
                int depth = children[0].Item1;
                TreeNode currentNode = children[0].Item2;
                children.RemoveAt(0);

                if (currentNode.left == null && currentNode.right == null) { return depth; }

                if (currentNode.left != null) children.Add(new Tuple<int, TreeNode>(depth + 1, currentNode.left));
                if (currentNode.right != null) children.Add(new Tuple<int, TreeNode>(depth + 1, currentNode.right));

            }

            return -1;
        }
    }
}
