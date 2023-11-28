using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int N;
        if (!int.TryParse(input, out N))
        {
            N = 0;
        }

        int m = N / 5;
        int diff = N % 5;

        int result = (diff <= 2) ? m * 5 : (m + 1) * 5;

        Console.WriteLine($"{result}");
    }
}
