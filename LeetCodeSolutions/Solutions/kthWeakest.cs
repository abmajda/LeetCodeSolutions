using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class kthWeakest
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] weakest = new int[k];
            List<KeyValuePair<int, int>> keys = new List<KeyValuePair<int, int>>();

            // create the list
            for (int i = 0; i < mat.Length; i++)
            {
                int soldiers = 0;

                for (var j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        soldiers++;
                    } 
                    else
                    {
                        break;
                    }
                }

                keys.Add(new KeyValuePair<int, int>(i, soldiers));
            }

            keys.Sort((x, y) =>
            {
                if (x.Value == y.Value)
                {
                    return x.Key - y.Key;
                }
                else
                {
                    return x.Value - y.Value;
                }
            });

            for (int i = 0; i < k; i++)
            {
                weakest[i] = keys[i].Key;
            }

            return weakest;
        }
    }
}
