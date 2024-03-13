//practiceA.cs
##################################
1
2 3
test
##################################
##################################
##################################
##################################
##################################
##################################
##################################
##################################
##################################
##################################
using System.Linq;

var a = int.Parse(Console.ReadLine());
var tmp=Console.ReadLine().Split().Select(int.Parse).ToList();
var b = tmp[0];
var c = tmp[1];
var s=Console.ReadLine();

Console.WriteLine(a + b + c + " " + s);
##################################
using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int b = int.Parse(input[0]);
        int c = int.Parse(input[1]);
        string s = Console.ReadLine();
        Console.WriteLine(a + b + c + " " + s);
    }
}
##################################
using System;
class Program
{
	static void Main(string[] args)
	{
		// 整数の入力
		int a = int.Parse(Console.ReadLine());
		// スペース区切りの整数の入力
		string[] input = Console.ReadLine().Split(' ');
		int b = int.Parse(input[0]);
		int c = int.Parse(input[1]);
		// 文字列の入力
		string s = Console.ReadLine();
		//出力
		Console.WriteLine((a+b+c) + " " + s);
	}
}
##################################
