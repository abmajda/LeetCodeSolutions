using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class RecoverBinaryTreeSearch
    {
        List<(int, TreeNode)> treeList;
        public void RecoverTree(TreeNode root)
        {
            TreeNode first = null;
            TreeNode second = null;

            treeList = new List<(int, TreeNode)> ();

            // traverse the tree inorder to collect a list
            createTreeList(root);

            // traverse the list to find something out of order
            for (int i = 0; i < treeList.Count; i++)
            {
                bool outOfOrder = false;

                if (i != 0 && treeList[i - 1].Item1 > treeList[i].Item1)
                {
                    outOfOrder = true;
                }

                if (i != treeList.Count - 1 && treeList[i].Item1 > treeList[i + 1].Item1)
                {
                    outOfOrder = true;
                }

                if (outOfOrder)
                {
                    if (first == null)
                    {
                        first = treeList[i].Item2;
                    }
                    else
                    {
                        second = treeList[i].Item2;
                    }
                }
            }

            // swap them
            swapTreeNodes(first, second);
        }

        private void createTreeList(TreeNode node)
        {
            // go left
            if (node.left != null)
            {
                createTreeList(node.left);
            }

            treeList.Add((node.val, node));

            // go right
            if (node.right != null)
            {
                createTreeList(node.right);
            }
        }

        private void swapTreeNodes(TreeNode node1, TreeNode node2)
        {
            // assign to temp values
            int tempVal = node1.val;
            node1.val = node2.val;
            node2.val = tempVal;
        }
    }
}
