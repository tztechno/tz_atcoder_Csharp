using System;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        char[] charArray = S.ToCharArray();

        char temp = charArray[a - 1];
        charArray[a - 1] = charArray[b - 1];
        charArray[b - 1] = temp;

        S = new string(charArray);

        Console.WriteLine(S);
    }
}


#############################

using System;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        // Ensure indices are valid
        if (a > 0 && b > 0 && a <= S.Length && b <= S.Length)
        {
            // Convert string to char array for manipulation
            char[] charArray = S.ToCharArray();

            // Swap characters at indices a-1 and b-1
            char temp = charArray[a - 1];
            charArray[a - 1] = charArray[b - 1];
            charArray[b - 1] = temp;

            // Convert char array back to string
            S = new string(charArray);

            Console.WriteLine(S);
        }
        else
        {
            Console.WriteLine("Invalid indices.");
        }
    }
}
