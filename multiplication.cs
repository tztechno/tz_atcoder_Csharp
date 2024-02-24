//abc169_a multiplication.cs
################################
################################
################################
################################
################################
string[] a = Console.ReadLine().Split(' ');
int b = int.Parse(a[0]);
int c = int.Parse(a[1]);
Console.WriteLine(b * c);
################################
long[] inputs = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
long multiple = inputs[0] * inputs[1];
Console.WriteLine($"{multiple}");
################################
using System;
public class A
{
  static void Main()
  {
    string[] t = Console.ReadLine().Split();
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    Console.Write(a * b);
  }
}
################################
using System;
namespace ABC169A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(' ');
            int a = int.Parse(word[0]);
            int b = int.Parse(word[1]);
            int x;
            x = a * b;
            Console.WriteLine(x);
        }
    }
}

################################
using System;
using System.Linq;
class Program
{
    static void Main()
    {
    int[] X = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine(X[0]*X[1]);
    }       
}
################################
