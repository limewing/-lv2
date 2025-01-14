Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int fac = 1;

if (num != 0)
    for (int i = 1; i <= num; i++)
        fac *= i;

Console.Write($"Factorial of {num} is {fac}");
