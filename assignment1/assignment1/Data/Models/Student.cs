using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string FName { get; set; }
        public string? LName { get; set; }
        [Required]
        public int Age { get; set; }
        public string? Address { get; set; }


        public int Dept_Id { get; set; }
        public List<Stud_Course> Courses { get; set; }

    }
}
