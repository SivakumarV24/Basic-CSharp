using System;
namespace StringManipulation
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write($"Enter Input : ");
            string[] input=Console.ReadLine().Split(",");
            for(int i=0;i<input.Length;i++)
            {
                Console.WriteLine($"{i+1}. {input[i]}");                
            }
        }
    }
}