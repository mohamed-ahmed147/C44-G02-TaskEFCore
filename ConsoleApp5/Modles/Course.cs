using ConsoleApp5.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp5.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(name: "Course Name", TypeName = "varchar(50)")]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        public int Duration { get; set; }

        public string? Description { get; set; }
        public int Top_Id { get; set; }
        public required ICollection<Student> Students { get; set; }
        public required ICollection<Topic> Topics { get; set; }
    }
}