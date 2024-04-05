using System;
namespace SwitchCase;
class Program {
    public static void Main(string[] args)
    {
        //Getting inputs from user
        Console.Write("Enter first Number: ");
        float firstNumber=float.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        float secondNumber=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a operation to perform:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1.Additon");
        Console.WriteLine("2.subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("5.Modulo");
        int option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
                Console.WriteLine($"The Result value: {firstNumber+secondNumber}");
                break;
            }
            case 2:
            {
                Console.WriteLine($"The Result value: {firstNumber-secondNumber}");
                break;
            }
            case 3:
            {
                Console.WriteLine($"The Result value: {firstNumber*secondNumber}");
                break;
            }
            case 4:
            {
                Console.WriteLine($"The Result value: {firstNumber/secondNumber}");
                break;
            }
            case 5:
            {
                Console.WriteLine($"The Result value: {firstNumber%secondNumber}");
                break;
            }
            default:
            {
                Console.WriteLine("Operation is invalid ");
                break;
            }
        }


    }
}
