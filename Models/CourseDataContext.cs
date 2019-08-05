using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Capstone.Models
{
    public class CourseDataContext : DbContext
    {
        public CourseDataContext(DbContextOptions<CourseDataContext> options)
               : base(options)
        { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
    }
}

