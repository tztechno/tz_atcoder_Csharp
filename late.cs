//ABC177_A late

using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int D = int.Parse(inputs[0]);
        int T = int.Parse(inputs[1]);
        int S = int.Parse(inputs[2]);

        if (D<=T*S){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");                
        }
    }
}
