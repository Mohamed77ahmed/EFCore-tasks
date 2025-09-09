using assignment1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Data.Configurations
{
    internal class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(s => new { s.Stud_Id, s.Course_Id });
            builder.HasOne(sc => sc.Students)
               .WithMany(s => s.Courses)
               .HasForeignKey(sc => sc.Stud_Id)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sc => sc.Courses)
                   .WithMany(c => c.Students)
                   .HasForeignKey(sc => sc.Course_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
