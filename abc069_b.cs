abc069_b.cs
#########################################
文字と数字の結合
Console.WriteLine($"{S[0]}{n-2}{S[n-1]}");
数値の文字化
.ToString()
#########################################
#########################################
#########################################
#########################################
#########################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ConsoleApp4
{
    class Program
    {
        //Console.ReadLine().Split(' ').ToArray();
        //Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans = s.Substring(1, s.Length - 2);
            Console.WriteLine(s[0].ToString() + ans.Length + s[s.Length - 1].ToString());
        }
    }
}

#########################################
string input = Console.ReadLine();

string ans = input.Substring(0, 1) + (input.Length - 2).ToString() + input.Substring(input.Length - 1);

Console.WriteLine(ans);
#########################################
using System;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int n = S.Length;
            Console.WriteLine($"{S[0]}{n-2}{S[n-1]}");
        }
    }
}
#########################################
