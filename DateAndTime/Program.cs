using System;
namespace DateAndTime;
class Program{
    public static void Main(string[] args)
    {
        // Exercise --1
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"Year : {date.Year}");
        Console.WriteLine($"Month : {date.Month}");
        Console.WriteLine($"Day : {date.Day}");
        Console.WriteLine($"Hour : {date.Hour}");
        Console.WriteLine($"Minute : {date.Minute}");
        Console.WriteLine($"Second : {date.Second}");

        //Exercise --2
        DateTime date1;
        Console.WriteLine("Enter the Date in this Format: dd/MM/yyy hh:mm:ss tt");
        bool temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date1);
        string dateTime=date.ToString();
        Console.WriteLine(dateTime);
        string results="";
        for(int i=0;i<dateTime.Length;i++)
        {
            if (dateTime[i].Equals(' ') ||dateTime[i].Equals(':')||dateTime[i].Equals('/'))
            {
                results+=" ";
            }
            else
            {
                results+=dateTime[i];
            }
        }
        string[] array=results.Split(" ");
        for(int i=array.Length-1;i>=0;i--)
        {
            Console.Write($"{array[i]}"+" ");
        }
        Console.WriteLine();
        //Exercise --3
         DateTime date2;
        Console.WriteLine("Enter the Date in this Format: yyyy/MM/dd hh:mm:ss");
        bool temp1=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss",null,System.Globalization.DateTimeStyles.None,out date2);
        Console.WriteLine($"Year : {date2.Year}");
        Console.WriteLine($"Month : {date2.Month}");
        Console.WriteLine($"Day : {date2.Day}");

    }
}