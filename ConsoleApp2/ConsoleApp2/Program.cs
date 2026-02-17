using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            char[,] board = {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

            char currentPlayer = 'X';
            int moves = 0;
            bool gameRunning = true;

            Console.WriteLine("--- Tic Tac Toe ---");

            while (gameRunning)
            {
                Console.WriteLine("\nCurrent Board:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Player " + currentPlayer + "'s Turn");

                int row, col;

                while (true)
                {
                    Console.Write("Enter Row (0, 1, or 2): ");
                    while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2)
                    {
                        Console.Write("Invalid! Please enter 0, 1, or 2: ");
                    }

                    Console.Write("Enter Column (0, 1, or 2): ");
                    while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col > 2)
                    {
                        Console.Write("Invalid! Please enter 0, 1, or 2: ");
                    }

                    if (board[row, col] != '-')
                    {
                        Console.WriteLine("Spot is already taken! Try again.");
                    }
                    else
                    {
                        break;
                    }
                }

                board[row, col] = currentPlayer;
                moves++;

                if (CheckWin(board, currentPlayer))
                {
                    Console.WriteLine("\nFinal Board:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(board[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Player " + currentPlayer + " Wins!");
                    gameRunning = false;
                }
                else if (moves == 9)
                {
                    Console.WriteLine("It's a Draw!");
                    gameRunning = false;
                }
                else
                {
                    if (currentPlayer == 'X') currentPlayer = 'O';
                    else currentPlayer = 'X';
                }
            }

        }

        static bool CheckWin(char[,] b, char p)
        {
            if (b[0, 0] == p && b[0, 1] == p && b[0, 2] == p) return true;
            if (b[1, 0] == p && b[1, 1] == p && b[1, 2] == p) return true;
            if (b[2, 0] == p && b[2, 1] == p && b[2, 2] == p) return true;

            if (b[0, 0] == p && b[1, 0] == p && b[2, 0] == p) return true;
            if (b[0, 1] == p && b[1, 1] == p && b[2, 1] == p) return true;
            if (b[0, 2] == p && b[1, 2] == p && b[2, 2] == p) return true;

            if (b[0, 0] == p && b[1, 1] == p && b[2, 2] == p) return true;
            if (b[0, 2] == p && b[1, 1] == p && b[2, 0] == p) return true;

            return false;
        }
    }
}