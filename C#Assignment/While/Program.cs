using System;
namespace While
{
    public class Program{
        public static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine($"Which city is Capital of India");
                Console.WriteLine($"1. Chennai\n2. Delhi\n3. Mumbai\n4. Kolkata");
                Console.Write($"Enter Your Choice : ");
                int response=int.Parse(Console.ReadLine());
                if(response==2)
                {
                    flag=false;
                }
                else
                {
                    Console.WriteLine($"Incorrect!");
                    Console.WriteLine($"Press Y to continue, Press N to Close");
                    string res=Console.ReadLine();
                    if(res.ToUpper()=="Y")
                    {
                        flag=true;
                    }
                    else
                    {
                        flag=false;
                    }
                }
            }
        }
    }
}