using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        // Getting inputs from user
        Console.Write("Enter Your Mark: ");
        float mark=float.Parse(Console.ReadLine());
       // condition check and printing Results
        if(mark>80 && mark<=100)
        {
            Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark<=80)
        {
            Console.WriteLine("Grade B");
        }
        else if(mark>35 && mark<=60)
        {
            Console.WriteLine("Grade C");
        }
        else if(mark<36 && mark>=0)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}