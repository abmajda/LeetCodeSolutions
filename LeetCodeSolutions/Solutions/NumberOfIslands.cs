using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class NumberOfIslands
    {
        private char[][] gridToModify;

        public int NumIslands(char[][] grid)
        {
            gridToModify = grid;
            int numOfIslands = 0;

            // loop through the grid and check if we have a 1, if so increment the counter
            for (int i = 0; i < gridToModify.Length; i++)
            {
                for (int j = 0; j < gridToModify[i].Length; j++)
                {
                    if (gridToModify[i][j] == '1')
                    {
                        numOfIslands++;

                        // look through the surrounding areas and explore the island
                        exploreSurrounding(j, i);
                    }
                }
            }

            return numOfIslands;
        }

        private void exploreSurrounding(int x, int y)
        {
            if (this.gridToModify[y][x] == '1')
            {
                // modify the array
                this.gridToModify[y][x] = 'X';

                // keep an offset array for x and y
                int[] xArray = new int[] { 0, 1, 0, -1 };
                int[] yArray = new int[] { -1, 0, 1, 0 };

                // loop through offset, checking for out of bounds
                for (int i = 0; i < xArray.Length; i++)
                {
                    // if not out of bounds recursivly call this
                    if (x + xArray[i] < this.gridToModify[y].Length && x + xArray[i] >= 0)
                    {
                        if (y + yArray[i] < this.gridToModify.Length && y + yArray[i] >= 0)
                        {
                            exploreSurrounding(x + xArray[i], y + yArray[i]);
                        }
                    }
                }
            }
        }
    }
}
