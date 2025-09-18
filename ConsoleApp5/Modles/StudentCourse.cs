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
    [PrimaryKey (nameof (Stud_Id) , nameof (Course_Id))]
    internal class StudentCourse
    {
        
        public int Stud_Id { get; set; }
        
        public int Course_Id { get; set; }
        [Required]
        [Column (TypeName ="varchar(2)")]
        public string Grade { get; set; }
    }
}
