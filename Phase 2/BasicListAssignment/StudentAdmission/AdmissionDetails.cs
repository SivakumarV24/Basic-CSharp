using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public enum AdmissionStatus{
        Select,
        Admitted,
        Cancelled
    }
    public class AdmissionDetails
    {
         private static int s_id=1000;
        public AdmissionDetails()
        {
            s_id++;
            AdmissionID="AID"+s_id;
        }
        public string AdmissionID { get; set; }
        public string StudentId { get; set; }
        public string DepartmentID { get; set; }
        public string AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }
        
    }
}