//abc093_a.cs
####################################
####################################
####################################
####################################
####################################
####################################
class Problem
{
    static void Main()
    {
        
        Console.WriteLine(Console.ReadLine().ToCharArray().Distinct().Count() == 3?"Yes":"No");
    }
}
####################################
            string m = Console.ReadLine();
            if ((m[0] == 'a' || m[1] == 'a' || m[2] == 'a')&&(m[0] == 'b' || m[1] == 'b' || m[2] == 'b')&&(m[0] == 'c' || m[1] == 'c' || m[2] == 'c'))
                        Console.WriteLine("Yes");
            else Console.WriteLine("No");
####################################
using System;

namespace ABC_093_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == "abc" || s == "acb" || s == "bca" || s == "bac" || s == "cab" || s == "cba")
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

####################################
using System;

class Problem
{
    static void Main()
    {
        string s = Console.ReadLine();
        var ans = "";
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        s = new string(chars);
        if (s == "abc") 
            ans = "Yes";
        else 
            ans = "No";
        Console.WriteLine(ans);
    }
}
####################################
