using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Capstone.Models
{
    public class MultiViewModel
    {
        public Student StudentID { get; }
        public List<Enrollment> Enrollment { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        
    }
}
