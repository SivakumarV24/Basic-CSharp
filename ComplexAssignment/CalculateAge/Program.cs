using System;
namespace CalculateAge;
class Program{
    public static void Main(string[] args)
    {
       
        DateTime startdate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        DateTime enddate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        TimeSpan span=enddate-startdate;
        int age=(int)(span.TotalDays/365);
        Console.WriteLine($"Age : {age}");
        Console.WriteLine($"Day : {startdate.DayOfWeek}");
        Console.WriteLine($"Number of days : {span.Days}");
        Console.WriteLine($"Number of hours : {(int)span.TotalHours}");
        Console.WriteLine($"Number of minutes : {(int)span.TotalMinutes}");
    }
}