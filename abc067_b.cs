abc067_b.cs
#########################################
int[] numbersLong = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] sortedNumbers = numbersLong.OrderDescending().ToArray();
        A.Sort();
        A.Reverse();
        var sum = A.Take(k).Sum();
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
using C = System.Console;
class Problem
{
    static int[] Read() => C.ReadLine().Split().Select(int.Parse).ToArray();
    static void Main()
    {
        int[] n = Read();
        C.Write(Read().OrderBy(x => x).Skip(n[0] - n[1]).Sum());
    }
}
#########################################
int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int N = input[0];
int K = input[1];
int[] numbersLong = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] sortedNumbers = numbersLong.OrderDescending().ToArray();
int snakeLong = 0;
for (int i = 0; i < K; i++)
{
    snakeLong += sortedNumbers[i];
}
Console.WriteLine(snakeLong);
#########################################
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var tmp = Console.ReadLine().Split().Select(int.Parse).ToList();
        var n = tmp[0];
        var k = tmp[1];
        var A = Console.ReadLine().Split().Select(int.Parse).ToList();
        A.Sort();
        A.Reverse();
        var sum = A.Take(k).Sum();
        Console.WriteLine(sum);
    }
}
#########################################
