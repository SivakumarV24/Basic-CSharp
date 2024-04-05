using System;
using System.Collections.Generic;
namespace StudentAdmission
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag=true;
            bool condition=true;
            List<StudentDetails> studentList=new List<StudentDetails>();
            Program program=new Program();
            //Welcom to Syncfusion Colleger Of Engineering and Technology.
            Console.WriteLine("Welcome to SCET");
            Console.WriteLine("----------------");
            Console.WriteLine();
            do{
                // Main Menu
                Console.WriteLine("       Main Menu     ");
                Console.WriteLine($"      ---------     ");
                Console.WriteLine("1. Student Registration");
                Console.WriteLine("2. Student Login");
                Console.WriteLine("3. Department wise seat availability");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                if(condition)
                {
                    Console.WriteLine("Enter the option Given Above : ");
                }
                else
                {
                    Console.WriteLine("You enter Wrong Option !. Enter the correct option Given Above : ");
                }

                // getting option from user.
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        // student Registration
                        string studentId=program.StudentRegistration(studentList);
                        Console.WriteLine($"Student Registered Successfully and StudentID is {studentId}. ");
                        break;
                    }
                    case 2:
                    {
                        StudentDetails details=new StudentDetails();
                        // Student Login
                        (bool login,StudentDetails studentDetails)=program.Login(studentList);
                        if(login)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Welcome {studentDetails.StudentName}.");
                            Console.WriteLine();
                            flag=true;
                            while(flag)
                            {

                            }
                            Console.WriteLine($"       Menu       ");
                            Console.WriteLine();
                            Console.WriteLine("a. Check Eligibility");
                            Console.WriteLine("b. Show Datails");
                            Console.WriteLine("c. Take Admission");
                            Console.WriteLine("d. Cancel Admission");
                            Console.WriteLine("e. Show Admission Details");
                            Console.WriteLine("f. Exit");
                            Console.Write($"Enter the option GIven Above: ");
                            char character=char.Parse(Console.ReadLine());
                            switch(character)
                            {
                                case 'a':
                                {
                                    details.CheckEligibility(studentDetails.Physics,studentDetails.Chemistry,studentDetails.Maths);
                                    break;
                                }
                                case 'b':
                                {
                                    break;
                                }
                                case 'c':
                                {
                                    break;
                                }
                                case 'd':
                                {
                                    break;
                                }
                                case 'e':
                                {
                                    break;
                                }
                                case 'f':
                                {
                                    break;
                                }
                                default :
                                {
                                    break;
                                }
                            }

                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid StudentID");
                        }
                        break;
                    }
                    case 3:
                    {
                        //Department wise seat availability
                        break;
                    }
                    case 4:
                    {
                        //Exit from Application
                        Console.WriteLine("------Thank You-----");
                        flag=false;
                        condition=false;
                        break;
                    }
                    default :
                    {
                        
                        break;
                    }
                }
                

            }while(flag);
        }
        // Student Registration Method
        public string StudentRegistration(List<StudentDetails> studentList)
        {
            bool flag=true;
            StudentDetails studentDetails=new StudentDetails();
            // getting student details from user.
            Console.WriteLine("       Welcome to registration      ");
            Console.WriteLine();
            // getting Student Name from user.
            Console.Write("Enter Student Name : ");
            string name="";
            while(flag)
            {
                name=Console.ReadLine();
                int count=0;
                for(int i=0;i<name.Length;i++)
                {
                    if((name[i]>='A' && name[i]<='Z')||(name[i]>='a'&& name[i]<='z')||name[i]==' ')
                    {
                        count++;
                    }
                }
                if(count==name.Length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You Entered Invaild Format !");
                    Console.Write("Name should Contain Alphabets. Enter Student Name : ");
                    

                }
            }
            // getting Father Name from user.
            Console.Write("Enter Father Name : ");
            flag=true;
            string fatherName="";
            while(flag)
            {
                fatherName=Console.ReadLine();
                int count=0;
                for(int i=0;i<fatherName.Length;i++)
                {
                    if((fatherName[i]>='A' && fatherName[i]<='Z')||(fatherName[i]>='a'&& fatherName[i]<='z')||fatherName[i]==' ')
                    {
                        count++;
                    }
                }
                if(count==fatherName.Length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You Entered Invaild Format !");
                    Console.Write("Name should Contain only Alphabets. Enter Student Name : ");
                }
            }
            // getting DOB from user.
            Console.Write("Enter Date of Birth (dd/MM/yyyy) : ");
            DateOnly date=new DateOnly();
            bool valid=false;
            while(!valid)
            {
                valid=DateOnly.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",out date);
                if(!valid)
                {
                    Console.Write("Invalid Format!.Enter Correct Date Format (dd/MM/yyyy) : ");
                }
            }
            // getting Gender from user.
            Console.Write("Enter Gender - Male, Female, Transgender : ");
            valid=false;
            Gender gender=Gender.Select;
            while(!valid)
            {
               valid=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
               if(!valid)
               {
                Console.Write("You Entered Invalid Gender!.Enter Gender Agin (Male,Female,Transgender) : ");
               }
            }
            // getting Physics Mark from user.
            Console.Write("Enter Physics Mark : ");
            valid=false;
            float physicsMark=0;
            while(!valid)
            {
                valid=float.TryParse(Console.ReadLine(),null,out physicsMark);
                if(physicsMark>=0 && physicsMark<=100)
                {
                    valid=true;
                }
                else
                {
                    Console.Write("Mark should be Number 1 to 100.Enter Physics Mark Again : ");
                    valid=false;
                }

            }
            // getting Chemistry Mark from user.
            Console.Write("Enter Chemistry Mark : ");
             valid=false;
            float chemistryMark=0;
            while(!valid)
            {
                valid=float.TryParse(Console.ReadLine(),null,out chemistryMark);
                if(chemistryMark>=0 && chemistryMark<=100)
                {
                    valid=true;
                }
                else
                {
                    Console.Write("Mark should be Number 1 to 100.Enter Chemistry Mark Again : ");
                    valid=false;
                }

            }
            // getting Maths Mark from user.
            Console.Write("Enter Maths Mark : ");
             valid=false;
            float mathsMark=0;
            while(!valid)
            {
                valid=float.TryParse(Console.ReadLine(),null,out mathsMark);
                if(mathsMark>=0 && mathsMark<=100)
                {
                    valid=true;
                }
                else
                {
                    Console.Write("Mark should be Number 1 to 100.Enter Maths Mark Again : ");
                    valid=false;
                }
            }
            // set value to the studentDetails property
            studentDetails.FatherName=fatherName;
            studentDetails.DOB=date;
            studentDetails.Gender=gender;
            studentDetails.Physics=physicsMark;
            studentDetails.Chemistry=chemistryMark;
            studentDetails.Maths=mathsMark;
            studentDetails.StudentName=name;
            // Add studentDetails object to studentList
            studentList.Add(studentDetails);
            // return StudentId;
            return studentDetails.StudentID;        
        }
        // Student Login Method
        public (bool,StudentDetails) Login(List<StudentDetails> studentList)
        {
            StudentDetails details=null;
            bool flag=false;
            Console.WriteLine("Welcome to Login");
            Console.WriteLine();
            Console.Write("Enter Your StudentID : ");
            string studentId=Console.ReadLine();
            studentId=studentId.ToUpper();
            foreach (StudentDetails studentDetails in studentList)
            {
                if(studentDetails.StudentID==studentId)
                {
                    details=studentDetails;
                    flag=true;
                }
            }
            return (flag,details);
        }
    }
}