abc077_b.cs
##############################################
##############################################
##############################################
##############################################
##############################################
using C = System.Console;
class Problem
{
    static void Main()
    {
        long n = long.Parse(C.ReadLine()), ans = 0;
        for (int i = 0; i * i <= n; i++) if (i * i <= n) ans = i * i;
        C.Write(ans);
    }
}
##############################################
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = (int)Math.Floor(Math.Sqrt(n));
        Console.WriteLine(m * m);
    }
}
##############################################
[python]
import math
n=int(input())
m=int(math.sqrt(n))
print(m**2)
##############################################
