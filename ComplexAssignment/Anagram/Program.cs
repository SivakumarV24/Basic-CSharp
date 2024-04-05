using System;
using System.Threading;
using System.Xml.XPath;
namespace Anagram;
public class Program{
    public static void Main(string[] args)
    {
        bool result=true;
        string one=Console.ReadLine();
        string two=Console.ReadLine();
        for(int i=0;i<one.Length;i++)
        {
            int count=0;
            for(int j=0;j<two.Length;j++)
            {
                if(one[i]==two[j])
                {
                    count++;
                }
            }
            if(count==0)
            {
                result=false;
            }
        }
        if(result)
        {
            Console.WriteLine("Anagram");
        }
        else
        {
            Console.WriteLine("Not a Anagram");
        }
    }
}