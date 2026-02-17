namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 101);
            int attemptsLeft = 5;
            bool hasWon = false;

            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine("You have " + attemptsLeft + " attempts to guess it.");

            while (attemptsLeft > 0 && !hasWon)
            {
                int currentAttempt = 6 - attemptsLeft;
                Console.Write("\nAttempt " + currentAttempt + "/5 - Enter your guess: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Correct! You won!");
                        hasWon = true;
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                        attemptsLeft--;
                    }
                    else
                    {
                        Console.WriteLine("Too low! Try again.");
                        attemptsLeft--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a whole number.");
                }
            }

            if (!hasWon)
            {
                Console.WriteLine("Game Over! You ran out of attempts. The number was " + secretNumber + ".");
            }


        }
    }
}