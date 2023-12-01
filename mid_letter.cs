using System;
class Program
{
    static void Main()
    {
        //Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int n = input.Length / 2;
        char ans = input[n];
        Console.WriteLine(ans);
    }
}
