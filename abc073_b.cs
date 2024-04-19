abc073_b.cs
#######################################
#######################################
#######################################
#######################################
#######################################
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                cnt += (a[1] - a[0] + 1);
            }
            Console.WriteLine(cnt);
        }
    }
}
#######################################
using C = System.Console;
class Problem
{
    static void Main()
    {
        int n = int.Parse(C.ReadLine());
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            int[] tmp = C.ReadLine().Split().Select(int.Parse).ToArray();
            ans += tmp[1] - tmp[0] + 1;
        }
        C.Write(ans);
    }
}
#######################################
[My AC]

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int t = 0;
        for (int i = 0; i < n; ++i) {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            t+=A[1]-A[0]+1;           
        }
        Console.WriteLine(t);
    }
}
#######################################
