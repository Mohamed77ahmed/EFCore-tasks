using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Models
{
    internal class Instructor
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }

        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal hourRate { get; set; }


        public int Dept_Id { get; set; }
        [InverseProperty(nameof(Department.manager))]
        public Department DepartmentToManage { get; set; }
        public List<Course_Inst> InsCourses { get; set; }

    }
}
