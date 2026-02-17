namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("enter the first number");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("enter the second Number");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("invalid input. Please enter a valid number.");
            }
            if (num1 > num2)
            {
                Console.WriteLine("the first number which was " + num1 + " is the higher number");
            }
            if (num1 < num2) { Console.WriteLine("The second number which was " + num2 + " is the higher number"); }
            if (num1 == num2) { Console.WriteLine("both number are equal"); }
        }
    }
}