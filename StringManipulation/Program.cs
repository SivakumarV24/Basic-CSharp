using System;

namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First String: ");
        string firstString=Console.ReadLine();
        Console.WriteLine("Enter Second String: ");
        string secondString=Console.ReadLine();
        if(firstString.Contains(secondString))
        {
            int len=firstString.Length-secondString.Length;
            int count=0;
            for(int i=0;i<=len;i++)
            {
                int start=i;
                string sub=firstString.Substring(start,secondString.Length);
                if(sub.Equals(secondString))
                {
                    count++;
                }          
            }
            Console.WriteLine($"String searched count is: {count++}");
            
        }
    }
}