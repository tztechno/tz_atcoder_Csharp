
using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine()?.Trim();
        int n = s.Length;
        if (n < 4)
        {
            s = s.PadLeft(4, '0');
        }
        Console.WriteLine(s);
    }
}
