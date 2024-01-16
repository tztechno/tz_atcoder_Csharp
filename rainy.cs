//abc175_a rainy.cs

###############################################
using System;

class Program
{
    static void Main()
    {
        string A = Console.ReadLine();
        int[] DP = { 0, 0, 0, 0 };

        for (int i = 0; i < 3; ++i)
        {
            if (A[i] == 'R')
            {
                DP[i + 1] = DP[i] + 1;
            }
        }

        Console.WriteLine(Max(DP)); 
    }

    static int Max(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}
###############################################

using System;

class Program
{
    static void Main()
    {
        string A = Console.ReadLine();
        int[] DP = { 0, 0, 0, 0 };
        int ans = 0;
        for (int i = 0; i < 3; ++i)
        {
            if (A[i] == 'R')
            {
                DP[i + 1] = DP[i] + 1;
                if (DP[i+1]>ans) {
                    ans=DP[i+1];
                }
            }
        }
        Console.WriteLine(ans); 
    }
}

###############################################

using System;

namespace _175_A___Rainy_Season
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int m = 3;
            if (s == "SRR" || s == "RRS")
                m = 2;
            if (s == "SSR" || s == "SRS" || s == "RSS" || s == "RSR")
                m = 1;
            if (s == "SSS")
                m = 0;
            Console.WriteLine(m);
        }
    }
}


###############################################

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

class Program {
    static void Main() {
        var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) {
            AutoFlush = false
        };
        Console.SetOut(sw);

        var s = Console.ReadLine();

        var ans = 0;
        var p = s[0] == 'R';
        var q = s[1] == 'R';
        var r = s[2] == 'R';

        if (p & q & r) {
            ans = 3;
        } else if ((p & q) | (q & r)) {
            ans = 2;
        } else if (p | q | r) {
            ans = 1;
        } else {
            ans = 0;
        }

        Console.WriteLine(ans);

        Console.Out.Flush();
    }
}

###############################################
