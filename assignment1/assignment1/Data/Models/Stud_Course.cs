using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Stud_Course
    {
        [ForeignKey(nameof(Students))]
        public int Stud_Id { get; set; }
        public Student Students { get; set; }


        [ForeignKey(nameof(Courses))]
        public int Course_Id { get; set; }
        public Course Courses { get; set; }


        public int Grade { get; set; }
    }
}
