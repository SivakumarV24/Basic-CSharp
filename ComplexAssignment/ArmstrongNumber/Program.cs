using System;
namespace ArmstrongNumber;
public class Program
{
    public static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
        for(int i=number;i<=number;i++)
        {
        int temp=i;
        int armstrong=i;
        string num=temp.ToString();
        int sum=0;
        while(armstrong>0)
        {
            int multiply=1;
            int length=num.Length;
            int remainder=armstrong%10;
            while(length>0)
            {
                multiply*=remainder;
                length--;
            }
            sum+=multiply;
            armstrong/=10;
        }
        if(sum==temp)
        {
            Console.WriteLine($"{i}");
        }

        }
    }
}
            