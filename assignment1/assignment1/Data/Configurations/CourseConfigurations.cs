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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        void IEntityTypeConfiguration<Course>.Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired().HasColumnType("varchar(20)");

            builder.Property(c => c.Description).HasColumnType("varchar(200)");

            //classify relationship
            builder.HasOne(c=>c.ClassifyTopics)
                .WithMany()
                .IsRequired(true)
                .HasForeignKey(c=>c.Top_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //// TakeCourse Relationship
            //builder.HasMany(c => c.Students)
            //        .WithMany(s => s.Courses)
            //        .UsingEntity<Stud_Course>(j => j.HasOne<Student>().WithMany().HasForeignKey(cs => cs.Stud_Id), j => j.HasOne<Course>().WithMany().HasForeignKey(cs => cs.Course_Id));

        }
    }
}
