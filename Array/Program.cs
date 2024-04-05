using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        //getting inputs from user
        int size=5;
        string[] names=new string[size];

        Console.WriteLine("Enter the Names :");
        for(int i=0;i<names.Length;i++)
        {
            names[i]=Console.ReadLine();
        }
        // print the Array elements
        Console.WriteLine("Display the Names: ");
        for(int i=0;i<size;i++)
        {
            Console.WriteLine($"{names[i]}");
        }
        //Getting input from user to search names
        Console.Write("Enter the Name to Search : ");
        String search=Console.ReadLine();
        //Printing the Results
        int count=0;
        //for loop
        for(int i=0;i<names.Length;i++)
        {
            if(names[i]==search)
            {
                if(count==0)
                {
                    Console.WriteLine($"The name is present in array");
                }
                Console.WriteLine($"The Index value is :{i}");
                Console.WriteLine($"The name is: {names[i]}");
                count=1;
                
            }
        }
        // foreach loop
        count=0;
        foreach(String i in names)
        {
            if(i==search)
            {
                if(count==0)
                {
                    Console.WriteLine($"The name is present in array");
                }
                count=1;
                
            }
        }
        if(count==0)
        {
            Console.WriteLine("The name is not present in array");
        }
        
    }
}