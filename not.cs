//ABC178_A Not


################################################
using System;

class Program
{
    static void Main()
    {
    string input = Console.ReadLine()?.Trim();
    int N = int.Parse(input);

    if (N==0) {
      Console.WriteLine(1);
    } else {
      Console.WriteLine(0);               
    }
  }
}
################################################

class Problem
{
    static void Main(string[] args)
    {
        int S = int.Parse(Console.ReadLine());
        if (S == 0) Console.WriteLine(1);
        else Console.WriteLine(0);
    }
}

################################################

using System;

namespace roo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, m;
            string[] word=Console.ReadLine().Split(' ');
            x = int.Parse(word[0]);
            m = 1 - x;
            Console.WriteLine(m);
        }
    }
}


################################################
