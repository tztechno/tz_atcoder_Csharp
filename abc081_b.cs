abc081_b.cs
##########################################
listのcopy
int[] B = (int[])A.Clone();
##########################################
##########################################
##########################################
##########################################
##########################################
int n = Int32.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(" ");
int[] arr = new int[n];

for (var i=0; i<n; i++)
{
  var v = Int32.Parse(input[i]);
  while (v>0)
  {
    if (v%2==0)
    {
      arr[i] ++;
      v /= 2;
    }
    else
    {
      break;
    }
  }
}

Array.Sort(arr);
Console.WriteLine(arr[0]);

##########################################
using System;
class Test
{
  static void Main()
  {
    string n = Console.ReadLine();
    int nNew = int.Parse(n);
    string[] nums = Console.ReadLine().Split(" ");
    int[] numsNew = Array.ConvertAll(nums, x => int.Parse(x));
    

    int res = 0;
    while (true)
    {
      bool flag = false;      
      foreach (int num in numsNew)
      {
        if (num % 2 != 0)
        {
          flag = true;
          break;
        }
      }
      if (flag)
      {
        Console.WriteLine(res);
        return;
      }
      for (int j = 0; j < nNew; j++)
      {
        numsNew[j] /= 2;
      }
      res++;
    }
  }
}
##########################################
[my ac]
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] B = (int[])A.Clone();
        int flag=1;
        for (int i=0 ; i<N*10 ; i++){
          for (int j=0 ; j<N ; j++){
            int bj=B[j];
            if (bj%2==0){
              B[j]=bj/2;             
              }
            else {
              Console.WriteLine(i);
              flag=0;
              break;                  
              }
            }
          if (flag==0){
            break;
          }
      }
   }
}

##########################################
[python]
N=int(input())
A=list(map(int,input().split()))
B=A
for i in range(N*10):
  for j in range(N):
    bj=B[j]
    if bj%2==0:
        B[j]=bj//2
    else:
        print(i)
        exit()
##########################################
