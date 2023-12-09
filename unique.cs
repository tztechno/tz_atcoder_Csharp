using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();

        // Using a HashSet to store unique characters
        HashSet<char> ss = new HashSet<char>(S);

        // Iterating through unique characters and finding the first non-repeating character
        foreach (char s in ss)
        {
            if (S.Count(c => c == s) == 1)
            {
                Console.WriteLine(s);
                return;
            }
        }

        // If no non-repeating character is found, print -1
        Console.WriteLine("-1");
    }
}
