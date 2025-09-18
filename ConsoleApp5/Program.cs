using ConsoleApp5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using ITIDbContext context = new ITIDbContext();
        
            var student = new Student() { Fname = "Mohamed", Lname = "Ahmed", Age = 20, Address = "GANN>D", DeptId = 1 };
            context.Students.Add(student);
          
            var Department = new Department() { Id = 1, Hiring_Date = DateTime.Now };
            context.Departments.Add(Department);
          
            var instuctors = new Instructor() { Name = "Mohamed", Salary = 50000, Hour_Rate = 205.25M, Department_Id = 1 };
            context.Instructors.Add(instuctors);


        }
        }
}
