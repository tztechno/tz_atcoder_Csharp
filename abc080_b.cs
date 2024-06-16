abc080_b.cs
##########################################
数字文字列をバラバラにして足す
int M=0;
foreach (char x in X)
{ M += int.Parse(x.ToString());}
##########################################
##########################################
##########################################
##########################################
##########################################
class Problem
{
  static void Main()
  {
    string X = Console.ReadLine();
    int Y=int.Parse(X.ToString());    
    int M=0;
    string ans;
    foreach (char x in X) { M+=int.Parse(x.ToString());}    
    if (Y%M==0) ans="Yes";
    else ans="No";
    Console.WriteLine(ans);
  }
}
##########################################
class Problem
{
  static void Main()
  {
    string X = Console.ReadLine();
    int M = 0;
    string ans;
    foreach (char x in X)
    {
      M += int.Parse(x.ToString());
    }    
    int Y=int.Parse(X.ToString());
    if (Y%M==0) 
      ans = "Yes";
    else 
      ans = "No";
    Console.WriteLine(ans);
  }
}
##########################################
[python]
X=str(input())
M=0
for x in list(X):
  M+=int(x)
if int(X)%M==0:
  print('Yes')
else:
  print('No')
##########################################
