//ABC179_A
//plural

using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine()?.Trim();
        int n = s.Length;
        if (s[n-1] == 's'){
            Console.WriteLine(s + "es");
        } else {
            Console.WriteLine(s + "s");
        }
    }
}
