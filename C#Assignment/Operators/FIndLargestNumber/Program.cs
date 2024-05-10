using System;
namespace FindLargestNumber
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write($"Enter the Number :");

            string input=Console.ReadLine();
            string[] number=input.Split(",");
            int numberone=int.Parse(number[0]);
            int numberTwo=int.Parse(number[1]);
            int numberThree=int.Parse(number[2]);
            if(numberone>numberThree && numberone>numberTwo)
            {
                Console.WriteLine($"{numberone} is largest Number");
                
            }
            else if(numberTwo>numberThree && numberTwo>numberone)
            {
                Console.WriteLine($"{numberTwo} is largest Number");
            }
            else
            {
                Console.WriteLine($"{numberThree} is largest Number");
                
            }

        }
    }
}