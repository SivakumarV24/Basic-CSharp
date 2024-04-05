using System;
using System.Net;
using System.Transactions;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        String option;
        bool repeat=true;
       
        do{
            Console.Write("Enter the Number: ");
            int input=int.Parse(Console.ReadLine());
            if(input%2==0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            Console.WriteLine("Do you repeat the process with another number ?  Yes/No");
            option=Console.ReadLine();
            bool response=true;
             while(response)
            {
                if(option.Equals("yes")||option.Equals("Yes"))
                {
                repeat=true;
                response=false;
                }
                else if(option.Equals("No")||option.Equals("no"))
                {
                    return;
                }
                else{
                    Console.Write("Invaild response !. Enter Yes/No :");
                    option=Console.ReadLine();
                }
            }
        }while(repeat);
    }
}
