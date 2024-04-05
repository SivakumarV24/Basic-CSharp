using System;
namespace ReadAndWrite;
class Program {
    public static void Main(string[] args)
    {
        // Getting the inputs
        Console.Write("Enter your Name: ");
        String name=Console.ReadLine();
        Console.Write("Enter your Father Name: ");
        String fatherName=Console.ReadLine();
        // printing the Results
        //concatenation
        Console.WriteLine(name+" "+fatherName);
        //placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        //Interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}
