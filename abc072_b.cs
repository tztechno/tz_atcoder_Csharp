abc072_b.cs
######################################
######################################
######################################
######################################
######################################
######################################
######################################
string S = Console.ReadLine();
string result = "";
for (int i = 0; i < S.Length; i++)
{
    if ((i + 1) % 2 == 1)
    {
        result += S[i];
    }
}
Console.WriteLine(result);
######################################
using System;

internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string ans = "";

        for (int i=0; i<s.Length; i +=2){
            ans += s[i];
        }
        Console.WriteLine(ans);
    }
}
######################################
using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string a = "";
            for (int i = 0; i < s.Length; i += 2)
            {
                a += s[i];
            }
            Console.WriteLine(a);
        }
    }
}
######################################
