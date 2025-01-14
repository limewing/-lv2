int[] num = { 10, 20, 30, 40, 50 };
int max = num[0];
int min = num[0];

for (int i = 1; i < num.Length; i++)
{
    if (num[i] > max)
        max = num[i];
    if (num[i] < min)
        min = num[i];
}

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");