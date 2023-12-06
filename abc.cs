using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);

        double result;

        if (N <= 125) {
            result = 4;
        } else if (N <= 211) {
            result = 6;
        } else {
            result = 8;
        }

        Console.WriteLine((int)result);
    }
}
