namespace ConsoleApp2
{
    internal class Program
    {
        static double Factorial(double number)
        {
            if (number == 0 || number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("enter a factorial number");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("enter a valid number");
            }
            Console.WriteLine("the factorial of " + number + " is " + Factorial(number));


        }
    }
}