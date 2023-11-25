using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        for (int i = 0; i < 256; ++i)
        {
            if ((A ^ i) == B)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
