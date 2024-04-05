using System;
using System.Linq.Expressions;
using System.Threading;
namespace QuestionOne;
class Program{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string input=Console.ReadLine();
        string[] array=input.Split(",");
        int element=0;
        String result="";
        for(int i=0;i<size;i++)
        {
            int number=int.Parse(array[i]);
            int count=0;
            for(int j=i;j<size;j++)
            {
                int number1=int.Parse(array[j]);
                if(result.Contains(array[i]))
                {
                    count=1;
                    break;
                }
                else if(number<number1)
                {
                    count++;
                }
            }
            if(count==0)
            {
                result+=number;
                element=1;
            }
        }
        if(element==0)
        {
            Console.WriteLine("No element Found");
        }
        else
        {
            for(int i=0;i<result.Length;i++)
            {
             Console.WriteLine(result[i]);
            }
        }
    }
}
