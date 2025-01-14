Console.WriteLine("구구단 가로출력");

for (int i = 2; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write(i);
        Console.Write(" * ");
        Console.Write(j);
        Console.Write(" = ");
        Console.Write(i * j);
        if (i * j < 10)
            Console.Write("   ");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("구구단 세로출력");

for (int i = 1; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.Write(j);
        Console.Write(" * ");
        Console.Write(i);
        Console.Write(" = ");
        Console.Write(i * j);
        if (i * j < 10)
            Console.Write("   ");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}
