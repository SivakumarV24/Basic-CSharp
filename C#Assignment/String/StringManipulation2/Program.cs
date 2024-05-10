using System;
namespace StringManipuulation2;
public class Program{
    public static void Main(string[] args)
    {
        Console.Write($"Enter First String : ");
        string firstinput=Console.ReadLine();
        Console.Write($"Enter Second String : ");
        string secondinput=Console.ReadLine();
        firstinput=firstinput.Substring(0,5);
        for(int i=secondinput.Length-3;i<secondinput.Length;i++)
        {
            firstinput+=secondinput[i];
        }
        Console.WriteLine($"{firstinput}");
    }
}