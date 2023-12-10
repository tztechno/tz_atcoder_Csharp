# tz_atcoder_csharp

        // a,b=map(int,input().split())  

        string[] input = Console.ReadLine().Split();  
        int a = int.Parse(input[0]);  
        int b = int.Parse(input[1]);  


        // S[b-1],S[a-1]=S[a-1],S[b-1]  

        char[] charArray = S.ToCharArray();  
        char temp = charArray[a - 1];  
        charArray[a - 1] = charArray[b - 1];  
        charArray[b - 1] = temp;  
        S = new string(charArray);  
        
