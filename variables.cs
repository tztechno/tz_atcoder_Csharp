//abc170_a variables.cs
#####################################
#####################################
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
public class A
{
	public static void Main(string[] args)
	{
		int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
		for (int i = 0; i < 5; i++){
			if (ints[i] == 0){
				i++;
				Console.WriteLine(i);
				break;
			}
		}
	}
}
#####################################
class Problem
{
    static void Main()
    {
        Console.Write(15-Console.ReadLine().Split(' ').Select(int.Parse).Sum());
    }
}
#####################################
using System;
public class A
{
  static void Main()
  {
    string[] t = Console.ReadLine().Split(" ");
    int sum = 0;
    for(int i = 0; i < 5; i++)
    {
      sum += int.Parse(t[i]);
    }
    Console.Write(15 - sum);
  }
}
#####################################
using System;
using System.Linq;
class Program
{
    static void Main()
    {
    int[] X = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int i=0; i<5; i++) {
        if (X[i]==0) {    
            Console.WriteLine(i+1);
            }       
        }
    }
}
#####################################
