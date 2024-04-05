using System;
namespace TypeConversion;
class Program {
    public static void Main(string[] args)
    {
        //Getting Inputs
        Console.Write("Enter your name: ");
        String name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter marl of subject1: ");
        float subject1=float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        float subject2=float.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        float subject3=float.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long phoneNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter mail id: ");
        String mailId=Console.ReadLine();
        // print the Result
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {phoneNumber}");
        Console.WriteLine($"Marks1: {subject1}");
        Console.WriteLine($"Marks2: {subject2}");
        Console.WriteLine($"Marks3: {subject3}");
        Console.WriteLine($"Total: {subject1+subject2+subject3}");
        float average=(subject1+subject2+subject3)/3;
        Console.WriteLine($"Average: {(average)}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Mail id: {mailId}");
    }
}