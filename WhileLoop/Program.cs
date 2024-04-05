using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        // Print even number 0 to 25
        int i=0;
         Console.WriteLine("--------------Exercise 1--------------------");
        Console.WriteLine("Even Numbers Are:");
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        Console.WriteLine("--------------Exercise 2--------------------");
        //Exercise-2
        //Getting inputs from user
        int number=0;
        bool isVaild=int.TryParse(Console.ReadLine(),out number); 
        while(!isVaild)
        {
            Console.Write("Invaild Number,Enter Again:");
            isVaild=int.TryParse(Console.ReadLine(),out number);                
              
            // printing the Results    
        }
        Console.WriteLine(number);
        
    }
}