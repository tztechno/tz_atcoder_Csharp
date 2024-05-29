abc079_b.cs
##########################################
C#におけるlist定義
List<long> L = new List<long> { 2, 1 };
long[] L = {2,1} ;
##########################################
要素追加はadd
L.Add(L[i - 2] + L[i - 1]);
##########################################
##########################################
##########################################
##########################################
using System;
namespace abc079
{
    class B
    {
        static void Main()
        {
            long[] L = {2,1} ;
            int N = int.Parse(Console.ReadLine());
            for (int i=1 ; i<N ; i++)
            {
                long num = L[0] + L[1];
                L[0] = L[1];
                L[1] = num;
            }
            Console.WriteLine(L[1]);
        }
    }
}
##########################################
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<long> L = new List<long> { 2, 1 };
        for (int i = 2; i <= N; i++)
        {
            L.Add(L[i - 2] + L[i - 1]);
        }
        Console.WriteLine(L[N]);
    }
}
##########################################
[WA,大きい数への対応が不足]
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<int> L = new List<int> { 2, 1 };
        for (int i = 2; i <= N; i++)
        {
            L.Add(L[i - 2] + L[i - 1]);
        }
        Console.WriteLine(L[N]);
    }
}
##########################################
[python]
N=int(input())
L=[2,1]
for i in range(N-1):
    L+=[L[-2]+L[-1]]
print(L[-1])
##########################################
