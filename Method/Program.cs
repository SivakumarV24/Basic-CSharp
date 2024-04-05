using System;
namespace Method;
class Program{
    public static void Main(string[] args)
    {
        bool option=true;
        do{
            Console.WriteLine("Enter the First Number: ");
            double firstNumber=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            double secondNumber=double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the option below to Perform Operation :");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            int operation=int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                {
                    Console.WriteLine($"Result : {Addition(firstNumber,secondNumber)}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Result : {Subtraction(firstNumber,secondNumber)}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Result : {Multiplication(firstNumber,secondNumber)}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Result : {Division(firstNumber,secondNumber)}");
                    break;
                }
                default :
                {
                    Console.WriteLine($"You Enter the wrong option");
                    break;
                }
            }
            Console.WriteLine("Do you want to continue ? Yes/No");
            String response=Console.ReadLine();
            bool repeat=true;
            while(repeat)
            {

                if(response.Equals("yes")|| response.Equals("Yes"))
                {
                    repeat=false;
                }
                else if(response.Equals("No")||response.Equals("no"))
                {
                    option=false;
                    repeat=false;
                }
                else
                {
                    Console.WriteLine("Your Enter Wrong Response. Enter Again : ");
                    response=Console.ReadLine();
                    repeat=true;
                }
            }

        }while(option);
    }
    static double Addition(double firstNumber,double secondNumber)
    {
        double sum=firstNumber+secondNumber;
        return  sum;
    }
     static double Subtraction(double firstNumber,double secondNumber)
    {
        double subtract=firstNumber-secondNumber;
        return  subtract;
    }
     static double Multiplication(double firstNumber,double secondNumber)
    {
        double multiply=firstNumber*secondNumber;
        return  multiply;
    }
     static double Division(double firstNumber,double secondNumber)
    {
        double divide=firstNumber/secondNumber;
        return  divide;
    }
}