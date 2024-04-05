using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                string input=Console.ReadLine();
                int length=input.Length;
                int odd=(length/2)+1;
                int count=0;
                int count1=0;
                int count2=0;
                for(int i=0;i<input.Length;i++)
                {
                    if(('{'==input[i])||('}'==input[i]))
                    {
                        if('{'==input[i])
                        {
                            count++;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else if(('['==input[i])||(']'==input[i]))
                    {
                        if('['==input[i])
                        {
                            count1++;
                        }
                        else
                        {
                            count1--;
                        }
                    }
                    else if(('('==input[i])||(')'==input[i]))
                    {
                        if('('==input[i])
                        {
                            count2++;
                        }
                        else
                        {
                            count2--;
                        }
                    }
                }
                if(count==0 && count1==0 && count2==0)
                {
                    Console.Write("1");
                }
                else{
                    Console.Write("0");
                }
            }
        }
            