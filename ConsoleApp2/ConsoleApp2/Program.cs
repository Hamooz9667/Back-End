using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[,] seatingChart = {
                { 1, 1, 0, 1 },
                { 1, 0, 1, 1 },
                { 1, 1, 1, 0 },
                { 0, 1, 1, 1 }
            };

            bool bookingComplete = false;

            Console.WriteLine("--- Movie Theater Seating Chart ---");
            Console.WriteLine("1 = Available | 0 = Booked");

            while (!bookingComplete)
            {
                Console.WriteLine("Current Seating Status:");
                for (int r = 0; r < 4; r++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write(seatingChart[r, c] + " ");
                    }
                    Console.WriteLine();
                }

                int row;
                Console.Write("Enter row number (0-3): ");
                while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 3)
                {
                    Console.Write("Invalid row. Please enter a number between 0 and 3: ");
                }

                int col;
                Console.Write("Enter seat number (0-3): ");
                while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col > 3)
                {
                    Console.Write("Invalid seat. Please enter a number between 0 and 3: ");
                }

                if (seatingChart[row, col] == 1)
                {
                    seatingChart[row, col] = 0;
                    Console.WriteLine("Success! Seat [" + row + "," + col + "] has been booked.");
                    bookingComplete = true;
                }
                else
                {
                    Console.WriteLine("Sorry, seat [" + row + "," + col + "] is already booked. Please pick another one.");
                }
            }


        }
    }
}