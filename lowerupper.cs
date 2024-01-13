//ABC192_B lowerupper

using System;
class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        int n = S.Length;
        for (int i = 0; i < n; i++)
        {
            if ((i % 2 == 0 && S[i] != char.ToLower(S[i])) || (i % 2 == 1 && S[i] != char.ToUpper(S[i])))
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("Yes");
    }
}
