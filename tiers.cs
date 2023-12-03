using System;

class Program
{
    static void Main()
    {
        //Console.Write("Enter a value for S: ");
        string S = Console.ReadLine();

        if (S.Length >= 2 && S.Substring(S.Length - 2) == "er")
        {
            Console.WriteLine("er");
        }
        else
        {
            Console.WriteLine("ist");
        }
    }
}
