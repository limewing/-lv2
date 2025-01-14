Random random = new Random();
int targetNumber = random.Next(1, 101);
int guess = 0;

do
{
    Console.Write("Enter your guess (1-100): ");
    guess = int.Parse(Console.ReadLine());
    if (guess < targetNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > targetNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number.");
    }
} while (guess != targetNumber);