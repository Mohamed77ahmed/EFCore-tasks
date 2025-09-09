using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        public List<Student> Students { get; set; }

        public int Ins_Id { get; set; }
        public Instructor manager { get; set; }
        public List<Instructor> ContainIns { get; set; }





    }
}
