//abc174_a conditioner.cs
####################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine(x >= 30 ? "Yes" : "No");
            Console.Read();
        }
    }
}
####################################
using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        if (X>=30)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");      
    }
}
####################################
using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        bool judge = (X >= 30);
        string[] ANS = { "No", "Yes" };
        Console.WriteLine(ANS[judge ? 1 : 0]);
    }
}
####################################
