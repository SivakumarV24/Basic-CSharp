using System;
using System.Reflection.PortableExecutable;
namespace HelloWorld;
    class Program 
    {
       public static void Main(string[] args)
       {
         /*   double number1=2;
            double number2=4;
            Console.WriteLine($"Multiplication : {multiply(number1,number2)}");
            float num1=2.1F;
            float num2=3.4F;
            divison(num1,num2);

       }
       static double multiply(double num1,double num2)
       {
         double result=num1*num2;
         return result;
       }
        static void divison(float num1,float num2)
       {
         float result=num1/num2;
         Console.WriteLine($"Divison : {result}");
       } */
      /* int number=10;
        string[] ones={"zero","one","two","three","four","five","six","seven","eight","nine","ten" };
        string[] tens={"eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"};
        string[] word={"ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety","Hundred"};
        if(number<=10)
        {
         Console.WriteLine($"{ones[number]}");
        }
        else if(number>10 && number>=20)
        {
         Console.WriteLine($"{tens[number-11]}");
        }
        else if(number>20&& number<100)
        {
          int temp=number;
          string text="";
          int value=temp/10;
          text=word[value-1];
          value=temp%10;
          if(value!=0)
          {
              text=text+" "+ones[value];
          }
          Console.WriteLine($"{text}");
        }
        else
        {
          Console.WriteLine($"{word[9]}");
        }*/
        /*int row=3;
        int column=1;
        int[,] number={{1,2,3}};
        for(int i=0;i<row;i++)
        {
          for(int j=0;j<column;j++)
          {
              Console.Write($"{number[j,i]} ");
          }
        Console.WriteLine();
        }
         string input1="s Smith";
          string input2="John Wilson";
          string[] firstName=input1.Split(" ");
          string[] secondName=input2.Split(" ");
          int lastname1=firstName.Length-1;
          int lastname2=secondName.Length-1;
          Console.WriteLine(firstName[lastname1]+""+secondName[lastname2]);
          Console.WriteLine(firstName[lastname1].CompareTo(firstName[lastname2]));
          if(firstName[lastname1].CompareTo(firstName[lastname2])<=0)
          {
              
              Console.WriteLine($"{input1}\n{input2}");
          }
          else{
              Console.WriteLine($"{input2}\n{input2}");
          }
          int size=3;
                int[] numbers=new int[size];
                int i=0;
                int temp=number;
                while(size>i)
                {
                    int j=2;
                    int count=0;
                    while(j<=temp)
                    {
                        if(temp%j==0)
                        {
                            count++;
                        }
                        j++;
                    }
                    if(count==1)
                    {
                        numbers[i];
                        i++;
                    }
                    temp++;
                }
                int k=0;
                while(size>k)
                {
                    Console.WriteLine($"{numbers[k]}");
                    k++;
                }*/
                 int m=2;
               int n=3;
               float[,] matrix1={{1,2,3},{4,5,6}};
               float[,] matrix2={{7,8},{9,10},{11,12}};
               
               float result=0;
               for(int i=0;i<m;i++)
               {
                for(int j=0;j<m;j++)
                {
                    result=0;
                    for(int k=0;k<n;k++)
                    {
                        result+=matrix1[i,k]*matrix2[k,j];
                    }
                    Console.Write($"{result} ");
                }
                Console.WriteLine();
               }

       }
    }
            

       
      

     
  
