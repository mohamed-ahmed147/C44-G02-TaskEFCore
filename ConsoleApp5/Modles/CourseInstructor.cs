using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    [PrimaryKey(nameof(Course_Id), nameof(Ins_Id))]
    internal class CourseInstructor
    {
        
        public int Course_Id { get; set; }
       
        public int Ins_Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Evaluation { get; set; } 
    }
}
