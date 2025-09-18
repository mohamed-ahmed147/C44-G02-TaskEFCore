using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }

        public int Bouns { get; set; }
        public decimal Hour_Rate { get; set; }
        public int Dep_Id { get; set; }
        public int Department_Id { get; internal set; }
    }
}
