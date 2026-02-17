namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("please enter a number");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("please enter another number");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }
            Console.WriteLine("choose the arthemetic operation you want + , - , * , / ");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (operation == "/")
            {
                if (num2 == 0) { Console.WriteLine("dont Divide by zero"); }
                else { Console.WriteLine(num1 / num2); }
            }
            else { Console.WriteLine("Invalid input"); }
        }
    }
}