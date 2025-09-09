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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                   .HasColumnType("varchar(20)")
                   .IsRequired();
            //located relationship
            builder.HasMany(d => d.Students)
                .WithOne()
                .IsRequired(true)
                .HasForeignKey(d=>d.Dept_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // contain relationship
            builder.HasMany(d=>d.ContainIns)
                   .WithOne()
                   .IsRequired(false)
                   .HasForeignKey(i=>i.Dept_Id)
                   .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
