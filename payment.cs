//abc173_a payment.cs
##############################
using System;
class A {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    int a = n % 1000;
    if(a == 0) Console.WriteLine(a);
    else Console.WriteLine(1000 - a);
  }
##############################
using System;
using System.Data.SqlTypes;
using System.Linq;
namespace HelloWorld
{
    class Program
    {
        private static char o;
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((1000 - (n % 1000)) % 1000);
        }
    }
}
##############################
using System;
using System.Linq;
class Program
{
    public static void Main()
    {
        int N=int.Parse(Console.ReadLine());
        if(N%1000==0)Console.WriteLine(0);
        else Console.WriteLine(1000-N%1000);
    }
}
##############################
using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int A=(1000-N%1000)%1000;
        Console.WriteLine(A); 
    }
}
##############################
