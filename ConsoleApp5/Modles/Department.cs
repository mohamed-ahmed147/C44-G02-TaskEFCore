using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =10)]
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public int Ins_Id { get; set; }
    }
}
