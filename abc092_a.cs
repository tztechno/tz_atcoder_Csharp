//abc092_a.cs
################################
int[] n = new int[4];
for(int i = 0; i < n.Length; i++)
{
    n[i] = int.Parse(Console.ReadLine());
}
################################
################################
################################
################################
################################
using System;

namespace ABC092A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = a + c;
            if (e > a+d)
            {
                e = a + d;
            }
            if (e > b+c)
            {
                e = b + c;
            }
            if(e > b+d)
            {
                e = b + d;
            }
            Console.WriteLine(e);
        }
    }
}

################################
class Problem
{
    static void Main()
    {
        int[] n = new int[4];
        for(int i = 0; i < n.Length; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Math.Min(n[0], n[1]) + Math.Min(n[2], n[3]));
    }
}
################################
using System;

namespace Kyopro
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());
			var d = int.Parse(Console.ReadLine());

			Console.WriteLine(Math.Min(a, b) + Math.Min(c, d));
		}
	}
}
################################
#input given vertically
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = Environment.OSVersion.Platform == PlatformID.Unix ? "/dev/stdin" : "./input.txt";
        string[] inputArray = File.ReadAllLines(filePath);

        int a = int.Parse(inputArray[0]);
        int b = int.Parse(inputArray[1]);
        int c = int.Parse(inputArray[2]);
        int d = int.Parse(inputArray[3]);

        int ans = Math.Min(a, b) + Math.Min(c, d);
        Console.WriteLine(ans);
    }
}
################################
## if input given horizontally
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
        int ans = Math.Min(a, b) + Math.Min(c, d);
        Console.WriteLine(ans);
    }
}
################################
