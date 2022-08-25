using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class BinaryZigZagLevel
    {
        List<List<int>> levels;

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            this.levels = new List<List<int>>();
            IList<IList<int>> result = new List<IList<int>>();

            // handle root case
            if (root == null)
            {
                return result;
            }
            // go down the list to build the levels
            
            LevelNavigation(root, 0);

            for (int i = 0; i < levels.Count; i++)
            {
                if (i % 2 != 0)
                {
                    levels[i].Reverse();
                }

                // add to the result to use an IList
                result.Add(levels[i]);
            }

            return result;
        }

        private void LevelNavigation(TreeNode node, int level)
        {
            if (levels.Count < level + 1)
            {
                levels.Add(new List<int>());
            }

            levels[level].Add(node.val);

            if (node.left != null)
            {
                LevelNavigation(node.left, level + 1);
            }

            if (node.right != null)
            {
                LevelNavigation(node.right, level + 1);
            }
        }
    }
}
