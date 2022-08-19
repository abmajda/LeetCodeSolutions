using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class TicTacToeDesign
    {
        private int[][]? board = null;

        public TicTacToe(int n)
        {
            // create the board (jagged array)
            this.board = new int[n][];

            for (int i = 0; i < n; i++)
            {
                this.board[i] = new int[n];
            }
        }

        public int Move(int row, int col, int player)
        {
            // place on the board
            this.board[row][col] = player;

            // send are to check for winner
            if (horizontalCheck(row, col, player)) { return player; }
            if (verticalCheck(row, col, player)) { return player; }
            if (diagonalCheck(row, col, player)) { return player; }
            if (antiDiagonalCheck(row, col, player)) { return player; }

            // return winner value (can be 0)
            return 0;
        }

        private bool horizontalCheck(int row, int col, int player)
        {
            for (int i = 0; i < this.board[row].Length; i++)
            {
                if (this.board[row][i] != player)
                {
                    return false;
                }
            }

            return true;
        }

        private bool verticalCheck(int row, int col, int player)
        {
            for (int i = 0; i < this.board.Length; i++)
            {
                if (this.board[i][col] != player)
                {
                    return false;
                }
            }

            return true;
        }

        private bool diagonalCheck(int row, int col, int player)
        {
            for (int i = 0; i < this.board.Length; i++)
            {
                if (this.board[i][i] != player)
                {
                    return false;
                }
            }

            return true;
        }

        private bool antiDiagonalCheck(int row, int col, int player)
        {
            int boardLength = this.board.Length;
            for (int i = 0; i < boardLength; i++)
            {
                if (this.board[i][boardLength - 1 - i] != player)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
