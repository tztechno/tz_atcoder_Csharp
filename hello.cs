using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string A = inputs[0];

        if (A == "Hello,World!")
        {
            Console.WriteLine("AC");
        }
        else
        {
            Console.WriteLine("WA");
        }
    }
}
