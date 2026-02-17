using System.ComponentModel;

namespace ConsoleApp2
{
    struct Point
    {
        public double X;
        public double Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point a, b;

            Console.Write("Enter x1: ");
            while (!double.TryParse(Console.ReadLine(), out a.X))
            {
                Console.Write("Invalid input. Enter a valid number for x1: ");
            }

            Console.Write("Enter y1: ");
            while (!double.TryParse(Console.ReadLine(), out a.Y))
            {
                Console.Write("Invalid input. Enter a valid number for y1: ");
            }

            Console.Write("Enter x2: ");
            while (!double.TryParse(Console.ReadLine(), out b.X))
            {
                Console.Write("Invalid input. Enter a valid number for x2: ");
            }

            Console.Write("Enter y2: ");
            while (!double.TryParse(Console.ReadLine(), out b.Y))
            {
                Console.Write("Invalid input. Enter a valid number for y2: ");
            }

            double distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));

            Console.WriteLine("The Euclidean distance is: " + distance);
        }
    }
}