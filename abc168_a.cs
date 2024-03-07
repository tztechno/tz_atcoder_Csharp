//abc168_a.cs
################################
int a = int.Parse(s[n - 1].ToString());
if (new[] { 2, 4, 5, 7, 9 }.Contains(a))
################################
################################
################################
################################
class Problem
{
    static void Main()
    {
        string s = Console.ReadLine();
        char c = s[s.Length - 1];
        var ans = "";
        if (c is '3') ans = "bon";
        else if (c is '0' or '1' or '6' or '8') ans = "pon";
        else ans = "hon";
        Console.WriteLine(ans);
    }
}
################################
class A
{
  static void Main()
  {
    string s = Console.ReadLine();
    char c = s[s.Length - 1];
    if(c == '3')
    {
      Console.Write("bon");
      return;
    }
    char[] ptn = {'0', '1', '6', '8'};
    foreach(char p in ptn)
    {
      if(c == p)
      {
        Console.Write("pon");
        return;
      }
    }
    Console.Write("hon");
  }
}
################################
int tt = 1;
//tt = int.Parse(Console.ReadLine());
while (tt-- > 0) {
    int n = int.Parse(Console.ReadLine());
    string s = n.ToString();
    char c = s[s.Length - 1];
    if (c == '2' || c == '4' || c == '5' || c == '7' || c == '9') {
        Console.WriteLine("hon");
    } else if (c == '0' || c == '1' || c == '6' || c == '8') {
        Console.WriteLine("pon");
    } else {
        Console.WriteLine("bon");
    }
}
Console.ReadLine();
################################
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int n = s.Length;
        int a = int.Parse(s[n - 1].ToString());
        if (new[] { 2, 4, 5, 7, 9 }.Contains(a))
        {
            Console.WriteLine("hon");
        }
        else if (new[] { 0, 1, 6, 8 }.Contains(a))
        {
            Console.WriteLine("pon");
        }
        else
        {
            Console.WriteLine("bon");
        }
    }
}
################################
