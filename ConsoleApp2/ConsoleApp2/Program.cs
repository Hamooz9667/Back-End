namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("enter a number");
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.WriteLine("please enter a valid number");
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else { Console.WriteLine("number is odd"); }
        }
    }
}