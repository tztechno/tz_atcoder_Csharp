abc074_b.cs
#######################################
#######################################
#######################################
#######################################
#######################################
using System.Linq;

namespace abc074
{
    class B
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            var x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ans = 0;
            for (int i=0 ; i<N ; i++)
            {
                ans += Math.Min(x[i]*2,(K-x[i])*2);
            }
            Console.WriteLine(ans);
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
        int b = int.Parse(C.ReadLine());
        int[]A = C.ReadLine().Split().Select(int.Parse).ToArray();
        int ans = 0;
        foreach (int x in A)
            ans += Math.Min(x, Math.Abs(x - b));
        C.WriteLine(ans * 2);
    }
}

#######################################
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());        
        int[] X = Console.ReadLine().Split().Select(int.Parse).ToArray();        
        int S=0;
        for (int i=0; i<N; i++) {
           S+=Math.Min(X[i],K-X[i])*2;   
        }        
        Console.WriteLine(S);
    }
}
#######################################
