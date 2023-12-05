using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        List<string> name = new List<string> {"ACE", "BDF", "CEG", "DFA", "EGB", "FAC", "GBD"};

        if (name.Contains(s))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
