using System;
namespace AscendingOrderAndDescendingOrder;
public class Program{
    public static void Main(string[] args)
    {
        Console.Write($"Enter 10 numbers : ");
        string[] input=Console.ReadLine().Split(",");
        int[] numbers=new int[10];
        int[] even=new int[10];
        int[] odd=new int[10];
        int count=0;
        int evencount=0;
        int oddcount=0;
        for(int i=0;i<10;i++)
        {
            numbers[i]=int.Parse(input[i]);
        }
        for(int i=0;i<10;i++)
        {
            for(int j=0;j<10;j++)
            {
                if(numbers[i]<numbers[j])
                {
                    int temp=numbers[i];
                    numbers[i]=numbers[j];
                    numbers[j]=temp;
                }
            }
        }
        for(int i=0;i<10;i++)
        {
            if(numbers[i]%2==0)
            {
                even[evencount]=numbers[i];
                evencount++;
            }
            else if(numbers[i]==0)
            {
                 even[evencount]=numbers[i];
                evencount++;
            }
            else
            {
                odd[oddcount]=numbers[i];
                oddcount++;
            }
        }
        Console.Write($"Even Array : ");
        for(int i=0;i<evencount-1;i++)
        {
            Console.Write($"{even[i]} ");
            
        }
        Console.Write($"Old Array : ");
        for(int i=0;i<oddcount-1;i++)
        {
            Console.Write($"{odd[i]} ");
            
        }
        
    }
}