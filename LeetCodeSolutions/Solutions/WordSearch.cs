using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class WordSearch
    {
        private char[][]? board;

        public bool Exist(char[][] board, string word)
        {
            this.board = board;
            bool found = false;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (word.Length <= 1)
                        {
                            return true;
                        }
                        Dictionary<int, List<int>> visited = new Dictionary<int, List<int>>();

                        if (checkSurrounding(word, j, i, visited))
                        {
                            return true;
                        }
                    }
                }
            }

            return found;
        }

        private bool checkSurrounding(string modWord, int x, int y, Dictionary<int, List<int>> visited)
        {
            if (visited.ContainsKey(x))
            {
                visited[x].Add(y);
            }
            else
            {
                visited.Add(x, new List<int> { y });
            }

            bool found = false;
            if (modWord.Length == 1)
            {
                return false;
            }

            string newModWord = modWord.Substring(1, modWord.Length - 1);

            // check right
            int right = x + 1;
            if (right < board[0].Length)
            {
                bool rightValid = true;
                if (visited.ContainsKey(right))
                {
                    foreach (int yValue in visited[right])
                    {
                        if (yValue == y)
                        {
                            rightValid = false;
                            break;
                        }
                    }
                }

                if (board[y][right] == newModWord[0] && rightValid)
                {
                    if (newModWord.Length == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (checkSurrounding(newModWord, right, y, visited))
                        {
                            found = true;
                        }
                    }
                }
            }

            // check below
            int below = y + 1;
            if (below < board.Length)
            {
                bool belowValid = true;
                if (visited.ContainsKey(x))
                {
                    foreach (int yValue in visited[x])
                    {
                        if (yValue == below)
                        {
                            belowValid = false;
                            break;
                        }
                    }
                }

                if (board[below][x] == newModWord[0] && belowValid)
                {
                    if (newModWord.Length == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (checkSurrounding(newModWord, x, below, visited))
                        {
                            found = true;
                        }
                    }
                }
            }

            // check left
            int left = x - 1;
            if (left >= 0)
            {
                bool leftValid = true;
                if (visited.ContainsKey(left))
                {
                    foreach (int yValue in visited[left])
                    {
                        if (yValue == y)
                        {
                            leftValid = false;
                            break;
                        }
                    }
                }

                if (board[y][left] == newModWord[0] && leftValid)
                {
                    if (newModWord.Length == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (checkSurrounding(newModWord, left, y, visited))
                        {
                            found = true;
                        }
                    }
                }
            }

            // check above
            int above = y - 1;
            if (above >= 0)
            {
                bool aboveValid = true;
                if (visited.ContainsKey(x))
                {
                    foreach (int yValue in visited[x])
                    {
                        if (yValue == above)
                        {
                            aboveValid = false;
                            break;
                        }
                    }
                }

                if (board[above][x] == newModWord[0] && aboveValid)
                {
                    if (newModWord.Length == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (checkSurrounding(newModWord, x, above, visited))
                        {
                            found = true;
                        }
                    }
                }
            }

            return found;
        }
    }
}
