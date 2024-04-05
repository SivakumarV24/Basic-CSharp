using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class DepartmentDetails
    {
         private static int s_id=100;
        public DepartmentDetails()
        {
            s_id++;
            DepartmentID="DID"+s_id;
            NumberOfSeats=30;
        }
        public string DepartmentID { get; }
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }
    }
}