using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        //Getting the inputs
        Console.Write("Enter First Number :");
        int firstNumber=int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        int secondNumber=int.Parse(Console.ReadLine());
        // using For loop to find sum of square
        int sum=0;
        for(int i=firstNumber;i<=secondNumber;i++)
        {
            sum+=(i*i);
        } 
        //printing the Results
        Console.WriteLine(sum);
    }
}