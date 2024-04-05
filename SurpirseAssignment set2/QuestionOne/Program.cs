using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int size=int.Parse(Console.ReadLine());
                for(int i=1;i<=size*2;i++)
                {
                    for(int j=i;j<size;j++)
                    {
                        Console.Write(" ");
                    }
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write("* ");
                    }
                }
            }
        }
            