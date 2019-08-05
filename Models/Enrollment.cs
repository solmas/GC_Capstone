using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Capstone.Models
{
    public class Enrollment
    {
        public string EnrollmentID { get; set; }
        public string EnrollmentDate { get; set; }
        public int FinalGrade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        
    }
}
