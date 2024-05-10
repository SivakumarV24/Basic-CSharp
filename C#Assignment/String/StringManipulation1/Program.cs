using System;
namespace Stringmanipulation1
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write($"Enter the String :");
            string input=Console.ReadLine();
            Console.WriteLine();
            
            Console.Write($"Display the Oddnumber of Character : ");
            
            for(int i=1;i<input.Length;i+=2)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
            
            Console.Write($"Replace the Character n with N : ");
            string replace="";
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]=='n')
                {
                    replace+=input[i].ToString().ToUpper();
                }
                else
                {
                    replace+=input[i];
                }               
            }
            Console.WriteLine($"{replace}");
            string result="";
            for(int i=input.Length-1;i>=0;i--)
            {
                result+=input[i];
            }
            Console.WriteLine($"Reverse A string : {result}");
        }
    }
}