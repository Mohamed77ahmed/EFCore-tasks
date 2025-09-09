using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructors))]
        public int Inst_Id { get; set; }
        public Instructor Instructors { get; set; }

        [ForeignKey(nameof(InsCourses))]
        public int Crs_Id { get; set; }
        public Course InsCourses { get; set; }

        public string Evaluate { get; set; }

    }
}
