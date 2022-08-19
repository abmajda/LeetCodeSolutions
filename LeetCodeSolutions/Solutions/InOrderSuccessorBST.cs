using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    // placed here for reference
    public class TreeNode
    {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int x) { val = x; }
    }

    internal class InOrderSuccessorBST
    {
        // some data structure to hold order (stack)
        Stack<TreeNode>? inOrder = null;

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            this.inOrder = new Stack<TreeNode>();

            // traverse in order
            InorderTraversal(root);

            // keep popping off the stack and storing the last popped
            int stackCount = inOrder.Count;

            for (int i = 0; i < stackCount - 1; i++)
            {
                TreeNode sucessorNode = inOrder.Pop();

                // if peeped next one is the value, return the currently stored one
                if (inOrder.Peek().val == p.val)
                {
                    return sucessorNode;
                }
            }

            // otherwise at end return null
            return null;
        }

        // in order traversal that pushes to the stack
        private void InorderTraversal(TreeNode node)
        {
            if (node.left != null)
            {
                InorderTraversal(node.left);
            }

            this.inOrder.Push(node);

            if (node.right != null)
            {
                InorderTraversal(node.right);
            }
        }
    }
}
