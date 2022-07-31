using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    internal class TicTacToeWinner
    {
        public string Tictactoe(int[][] moves)
        {
            char turn = 'A';

            // set up the board
            char[][] board = new char[3][];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new char[] {' ', ' ', ' '};
            }

            // lop through moves and check winner
            for (int i = 0; i < moves.Length; i++)
            {
                board[moves[i][0]][moves[i][1]] = turn;

                string result = checkWinner(board, turn);

                if (result == turn.ToString())
                {
                    return result;
                }

                turn = switchTurn(turn);
            }

            if (moves.Length == 9)
            {
                return "Draw";
            }
            else
            {
                return "Pending";
            }
        }

        private string checkWinner(char[][] board, char turn)
        {
            string result = "Pending";

            result = checkDiagonal(board, turn);
            if (result == turn.ToString())
            {
                return result;
            }

            result = checkHorizontal(board, turn);
            if (result == turn.ToString())
            {
                return result;
            }

            result = checkVertical(board, turn);
            if (result == turn.ToString())
            {
                return result;
            }

            return result;
        }

        private string checkDiagonal(char[][] board, char turn)
        {
            if (board[0][0] == turn && board[1][1] == turn && board[2][2] == turn)
            {
                return turn.ToString();
            }

            if (board[2][0] == turn && board[1][1] == turn && board[0][2] == turn)
            {
                return turn.ToString();
            }

            return "Pending";
        }

        private string checkVertical(char[][] board, char turn)
        {
            for (int i = 0; i < 3; i++)
            {
                bool match = true;
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != turn)
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return turn.ToString();
                }
            }

            return "Pending";
        }

        private string checkHorizontal(char[][] board, char turn)
        {
            for (int i = 0; i < 3; i++)
            {
                bool match = true;
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[j][i] != turn)
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return turn.ToString();
                }
            }

            return "Pending";
        }

        private char switchTurn(char turn)
        {
            if (turn == 'A')
            {
                return 'B';
            }
            else
            {
                return 'A';
            }
        }
    }
}
