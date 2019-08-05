using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Capstone.Models
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Category { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
