abc068_b.cs
#########################################
Math.Pow(2, i)
for (int i = 1; i <= n; i *= 2) 
#########################################
#########################################
#########################################
#########################################
#########################################
using C = System.Console;
class Problem
{
    static void Main()
    {
        int n = int.Parse(C.ReadLine()), ans = 0;
        for (int i = 1; i <= n; i *= 2) ans = i;
        C.Write(ans);
    }
}
#########################################
var line1 = Console.ReadLine() ?? "";
int N = int.Parse(line1);
int n = 0;
int cnt;
int cmax = 0;
int max = 1;

for (int i = 1; i <= N; i++)
{
    cnt = 0;
    n = i;
    while (n % 2 == 0)
    {
        n = n / 2;
        cnt++;
    }
    if (cmax < cnt)
    {
        cmax = cnt;
        max = i;
    }
}

Console.WriteLine(max);
#########################################
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int ans = 0;
        for (int i = 0; i <= n; ++i)
        {
            if (Math.Pow(2, i) <= n)
            {
                ans = (int)Math.Pow(2, i);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(ans);
    }
}
#########################################
