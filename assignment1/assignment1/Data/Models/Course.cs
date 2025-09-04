using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
