using System;
namespace IfStatement;
public class Program{
    public static void Main(string[] args)
    {
        Console.Write($"Enter The Input : ");
        string input=Console.ReadLine();
        if(input.Equals("A"))
        {
            Console.WriteLine($"Grade A denotes 6 Points");
        }
        else if(input.Equals("B"))
        {
            Console.WriteLine($"Grade B denotes 6 Points");
        }
        else if(input.Equals("C"))
        {
            Console.WriteLine($"Grade C denotes 6 Points");
        }
        else if(input.Equals("D"))
        {
            Console.WriteLine($"Grade D denotes 6 Points");
        }
        else {
            Console.WriteLine($"This is not valid Grade");
            
        }
    }
}