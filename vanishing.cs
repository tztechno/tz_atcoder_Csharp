using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = Environment.OSVersion.Platform == PlatformID.Unix ? "/dev/stdin" : "./input.txt";
        string input;

        using (StreamReader reader = new StreamReader(filePath))
        {
            input = reader.ReadLine();
        }

        string[] inputArray = input.Split(' ');
        int V = int.Parse(inputArray[0]);
        int T = int.Parse(inputArray[1]);
        int S = int.Parse(inputArray[2]);
        int D = int.Parse(inputArray[3]);

        if (V * T <= D && D <= V * S)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}
