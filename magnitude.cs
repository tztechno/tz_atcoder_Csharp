using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        double result = Math.Pow(32, A - B);
        Console.WriteLine((int)result);
    }
}
