using System;
namespace MatrixMultiplication
{
   class Program{
    public static void Main(string[] args)
    {
        int m=int.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        float[,] matrix1=new float[m,n];
        float[,] matrix2=new float[n,m];
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }
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
}