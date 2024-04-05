using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        //Parse Method
        int num1=int.Parse(null);
        Console.WriteLine(num1);     //Return Zero
        //Convert Method
        int num2=Convert.ToInt32(null);
        Console.WriteLine(num2);      //Return exception
        // Getting int type input
        Console.Write("Enter the First Number: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number: ");
        int number2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a Double Number: ");
        double number3=double.Parse(Console.ReadLine());
        //Print the Result
        Console.WriteLine($"{number3}");
    
    }
}