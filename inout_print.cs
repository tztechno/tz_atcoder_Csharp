using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Nを入力
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        // Aを入力
        Console.Write("Enter A: ");
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // NとAを出力
        Console.WriteLine(N);
        Console.WriteLine(string.Join(" ", A));
    }
}
