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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        void IEntityTypeConfiguration<Instructor>.Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name)
                .HasColumnType("varchar(20)")
                .IsRequired();


            //Manage Relationship
            builder.HasOne(i => i.DepartmentToManage)
                   .WithOne(d => d.manager)
                   .IsRequired(true)
                   .HasForeignKey<Department>(d=>d.Ins_Id)
                   .OnDelete(DeleteBehavior.Cascade);

            //Teach Relationship
          
                 





        }
    }
}
