using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int  Duration { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(ClassifyTopics))]
        public int Top_Id { get; set; }
        public Topic ClassifyTopics { get; set; }
        public List<Stud_Course> Students { get; set; }
        public List<Course_Inst> Instructors { get; set; }

    }
}
