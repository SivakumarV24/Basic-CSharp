using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public enum Gender{
        Select,
        Male,
        Female,
        Transgender
    }
    public class StudentDetails
    {
        private static int s_id=3000;
        public StudentDetails()
        {
            s_id++;
            StudentID="SF"+s_id;
        }
        public string StudentID { get; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateOnly DOB { get; set; }
        public Gender Gender { get; set; }
        public float Physics { get; set; }
        public float Chemistry { get; set; }
        public float Maths {get; set; }
        public bool CheckEligibility(float Physics,float Chemistry,float Maths)
        {
            float average=(Physics+Chemistry+Maths)/3;
            if(average>=75.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}