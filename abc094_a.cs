//abc094_a.cs
####################################
####################################
####################################
####################################
####################################
class Problem
{
    static void Main()
    {
        int[]n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(n[0] <= n[2] && n[2] <= n[0] + n[1] ?"YES":"NO");
    }
}
####################################
using System;

namespace Kyopro
{
	class Program
	{
		static void Main(string[] args)
		{
			var abx = Console.ReadLine().Split(' ');
			var a = int.Parse(abx[0]);
			var b = int.Parse(abx[1]);
			var x = int.Parse(abx[2]);

			Console.WriteLine(a <= x && b >= x - a ? "YES" : "NO");
		}
	}
}
####################################
            int a, b, c;
            string[] word = Console.ReadLine().Split(' ');
            a = int.Parse(word[0]);
            b = int.Parse(word[1]);
            c = int.Parse(word[2]);

            if (c >= a && c <= a + b)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
####################################
using System;

class Program
{
    static void Main()
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int a = inputs[0];
        int b = inputs[1];
        int x = inputs[2];

        if (a <= x && x <= a + b)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
####################################
using System;
class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int x = int.Parse(inputs[2]);

        if (a<=x && x<=a+b) {
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");                
        }
    }
}

####################################
