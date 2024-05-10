using System;
namespace Foriteration
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write($"Enter 10 Numbers : ");
            int[]  numbers=new int[10];
            int sum=0;
            for(int i=0;i<10;i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
                sum+=numbers[i];
            }
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Average : {sum/10}");            
        }
    }
}