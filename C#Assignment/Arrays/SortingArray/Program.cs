using System;
namespace SortingArray
{
    public class Program{
        public static void Main(string[] args)
        {
            int[] numbers=new int[5];
            Console.WriteLine($"Enter 5  Numbers : ");
            string[] input=Console.ReadLine().Split(" ");
            for(int i=0;i<5;i++)
            {
                numbers[i]=int.Parse(input[i]);
            }
            for(int i=0; i<5;i++)
            {
                for(int j=0;j<4;j++)
                {
                    if(numbers[i]<numbers[j])
                    {
                        int temp=numbers[j];
                        numbers[j]=numbers[i];
                        numbers[i]=temp;
                    }
                }
            }
            Console.Write($"Sorted Array :");
            for(int i=0;i<5;i++)
            {
                Console.Write($"{numbers[i]} ");
                
            }
            
        }
    }
}