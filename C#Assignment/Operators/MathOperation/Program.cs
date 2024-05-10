using System;
namespace MathOperation
{
    public class Program{
        public static void Main(string[] args)
        {
            int numberOne=10;
            int numberTwo=20;
            Console.WriteLine($"Addition : {numberOne+numberTwo}");
            Console.WriteLine($"Subtraction : {numberOne-numberTwo}");
            Console.WriteLine($"Multiplication : {numberOne*numberTwo}");
            Console.WriteLine($"Divison : {numberOne/numberTwo}");
            Console.WriteLine($"Modulus : {numberOne%numberTwo}");            
        }
    }
}