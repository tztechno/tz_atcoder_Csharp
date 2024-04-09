abc070_b.cs
##############################
##############################
##############################
##############################
##############################
using C = System.Console;
class Problem
{
    static void Main()
    {
        int[]n = C.ReadLine().Split().Select(int.Parse).ToArray();
        int A = Math.Min(n[1], n[3]) - Math.Max(n[0], n[2]);
        C.Write(A < 0 ? 0 : A);
    }
}
##############################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution
{
    static void Main()
    {
        int[] ABCD = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(Math.Max(Math.Min(ABCD[1], ABCD[3]) - Math.Max(ABCD[0], ABCD[2]), 0));
    }
}
##############################
using System;

namespace Kyopro;

public class Program
{
	static void Main(string[] args)
	{
		var abcd = Console.ReadLine().Split(' ');
		var a = int.Parse(abcd[0]);
		var b = int.Parse(abcd[1]);
		var c = int.Parse(abcd[2]);
		var d = int.Parse(abcd[3]);

		var ans = 0;

		if (a <= c && c <= b && b <= d) {
			ans = b - c;
		} else if (c <= a && b <= d) {
			ans = b - a;
		} else if (c <= a && a <= d && d <= b) {
			ans = d - a;
		} else if (a <= c && d <= b) {
			ans = d - c;
		}

		Console.WriteLine(ans);
	}
}
##############################
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = Environment.OSVersion.Platform == PlatformID.Unix ? "/dev/stdin" : "./input.txt";
        string input;
        using (StreamReader reader = new StreamReader(filePath))
        {
            input = reader.ReadLine();
        }
        string[] inputArray = input.Split(' ');
        int a = int.Parse(inputArray[0]);
        int b = int.Parse(inputArray[1]);
        int c = int.Parse(inputArray[2]);
        int d = int.Parse(inputArray[3]);
        int ans = Math.Max(Math.Min(b,d)-Math.Max(a,c),0);
        Console.WriteLine(ans);
    }
}
##############################
