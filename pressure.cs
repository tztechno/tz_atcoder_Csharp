using System;

class Program
{
    static void Main()
    {
        //Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int D))
        {
            double ans = D / 100.0;
            Console.WriteLine(ans);
        }
        else
        {
            Console.Error.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
