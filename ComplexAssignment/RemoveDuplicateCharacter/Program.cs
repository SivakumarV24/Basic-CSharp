using System;
namespace RemoveDuplicateCharacter;
class Program{
    public static void Main(string[] args)
    {
        string input=Console.ReadLine();
        char[] temp=input.ToCharArray();
        string result="";
        for(int i=0;i<input.Length;i++)
        {
           for(int j=0;j<input.Length;j++)
           {
            if(input[i]==input[j] && (!result.Contains(input[j])))
            {
                result=result+input[i];
            }
           }
        }
        Console.WriteLine(result);
    }
}
