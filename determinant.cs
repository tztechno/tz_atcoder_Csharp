using System;

class Program
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string[] values1 = input1.Split(' ');
        int a = int.Parse(values1[0]);
        int b = int.Parse(values1[1]);

        string input2 = Console.ReadLine();
        string[] values2 = input2.Split(' ');
        int c = int.Parse(values2[0]);
        int d = int.Parse(values2[1]);

        int ans = a * d - b * c;

        Console.WriteLine(ans);
    }
}

###################################################

using System;
using System.Collections.Generic;
using System.Text;

using A = System.Array;
using C = System.Console;

public class abc184a
{
    public static void Main(string[] args)
    {
        string[] s2 = C.ReadLine().Split(' ');
        int[] a = A.ConvertAll(s2, int.Parse);
        string[] s3 = C.ReadLine().Split(' ');
        int[] b = A.ConvertAll(s3, int.Parse);

        C.WriteLine(a[0] * b[1] - a[1] * b[0]);
    }
}
