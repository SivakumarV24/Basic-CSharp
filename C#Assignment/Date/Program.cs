using System;
namespace Date;
public class Program{
    public static void Main(string[] args)
    {
        DateTime dateTime=DateTime.Now;
        Console.WriteLine($"Current Month of the day : {dateTime.Day}");
        Console.WriteLine($"Print Previous 3 days :");
        Console.WriteLine($"{dateTime.AddDays(-3).ToString("dd/MM/yyyy")}");
        Console.WriteLine($"{dateTime.AddDays(-2).ToString("dd/MM/yyyy")}");
        Console.WriteLine($"{dateTime.AddDays(-1).ToString("dd/MM/yyyy")}");        
        Console.WriteLine($"{dateTime.AddDays(0).ToString("dd/MM/yyyy")}");        
        Console.WriteLine($"12 hour's time : {dateTime.ToString("hh:mm:ss tt")}");
        
        
    }
}