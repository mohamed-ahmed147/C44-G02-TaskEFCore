using ConsoleApp5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base() { }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI ; Trusted_Connection = true ; TrustServerCertificate= true; ");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }





    }
}
