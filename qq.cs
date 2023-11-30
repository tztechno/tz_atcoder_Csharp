using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string S = Console.ReadLine();

        int ans = (S[0] - '0') * (S[2] - '0');
        Console.WriteLine(ans);
    }
}
