using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int K = int.Parse(inputs[0]);

        int h = 21 + K / 60;
        int m = K % 60;

        string ans = $"{h:D2}:{m:D2}";

        Console.WriteLine(ans);
    }
}
