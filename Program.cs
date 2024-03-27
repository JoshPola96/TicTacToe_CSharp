using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the best game ever - ToeTicTac");

            char[,] board = new char[,]
{
                {'0','1','2'},
                {'3','4','5'},
                {'6','7','8'},
};
            int turn = 1;
            int numberOfMoves = 0;

            DisplayField(board);

            try
            {
                do
                {
                    if (turn == 1)
                    {
                        Console.WriteLine("\nChoose your spot, Player 1\n\n");
                        char move = GetValidMove(board);
                        MakePlay(board, turn, move); 
                        CheckWin(board, turn, ref numberOfMoves);
                        turn = 2;

                    }
                    else
                    {
                        Console.WriteLine("\nChoose your spot, Player 2\n\n");
                        char move = GetValidMove(board);
                        MakePlay(board, turn, move);
                        CheckWin(board, turn, ref numberOfMoves);
                        turn = 1;
                    }

                    numberOfMoves++;

                    if (numberOfMoves > 9)
                    {
                        Console.WriteLine("\nDraw Game. Please enter a key to restart or exit.");
                        Console.ReadLine();
                        ResetField(board, ref numberOfMoves);
                    }

                } while (numberOfMoves < 10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
                Console.ReadLine();
            }
        }

        private static char GetValidMove(char[,] board)
        {
            string input;
            char move = ' ';
            bool isValidInput = false;

            do
            {
                Console.WriteLine("\nEnter a valid position(0-8)");
                input = Console.ReadLine().Trim();

                if (input.Length == 1 && char.IsDigit(input[0]) && input[0] >= '0' && input[0] <= '8')
                {
                    move = Convert.ToChar(input);
                    int position = int.Parse(input);
                    int row = position / 3;
                    int col = position % 3;

                    if (board[row, col] != move)
                    { 
                        Console.WriteLine("\nPosition already occupied. Please use a different one.");
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("\nEnter a valid input");
                }

            } while (!isValidInput);

            return move;

        }


        public static void ResetField(char[,] board, ref int numberOfMoves)
        {
            char[,] defaultBoard = new char[,]
{
                {'0','1','2'},
                {'3','4','5'},
                {'6','7','8'},
};

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = defaultBoard[i, j];
                }
            }

            numberOfMoves = 0;

            DisplayField(board);
        }

        public static void DisplayField(char[,] board)
        {
            Console.Clear();
            Console.WriteLine("\n\n        |     |     ");
            Console.WriteLine("     " + board[0, 0] + "  |  " + board[0, 1] + "  |  " + board[0, 2] + "  ");
            Console.WriteLine("   _____|_____|_____");
            Console.WriteLine("        |     |     ");
            Console.WriteLine("     " + board[1, 0] + "  |  " + board[1, 1] + "  |  " + board[1, 2] + "  ");
            Console.WriteLine("   _____|_____|_____");
            Console.WriteLine("        |     |     ");
            Console.WriteLine("     " + board[2, 0] + "  |  " + board[2, 1] + "  |  " + board[2, 2] + "  ");
            Console.WriteLine("        |     |     ");
        }

        public static void MakePlay(char[,] board, int turn, char move)
        {
            char player;
            if (turn == 1) { player = 'X'; }
            else { player = 'O'; }

            switch (move)
            {
                case '0':
                    board[0, 0] = player;
                    break;
                case '1':
                    board[0, 1] = player;
                    break;
                case '2':
                    board[0, 2] = player;
                    break;
                case '3':
                    board[1, 0] = player;
                    break;
                case '4':
                    board[1, 1] = player;
                    break;
                case '5':
                    board[1, 2] = player;
                    break;
                case '6':
                    board[2, 0] = player;
                    break;
                case '7':
                    board[2, 1] = player;
                    break;
                case '8':
                    board[2, 2] = player;
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid move");
                    break;
            }
            DisplayField(board);
        }

        public static void CheckWin(char[,] board, int turn, ref int numberOfMoves)
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] ||
                board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] ||
                board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] ||
                board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
                board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] ||
                board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] ||
                board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] ||
                board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                string winner;
                winner = turn == 1 ? "Player 1" : "Player 2";
                Console.WriteLine("\nWinner is " + winner);
                Console.WriteLine("\nPress any key to start a new game, or close the window.");
                Console.ReadLine();
                ResetField(board, ref numberOfMoves);
            }
        }
    }
}