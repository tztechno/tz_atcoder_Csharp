//ABC182_A
//Follow
//input= 200 300

using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);
        int XB = 2*A+100;
        Console.WriteLine(XB-B);
    }
}
