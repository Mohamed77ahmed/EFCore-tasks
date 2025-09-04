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
    internal class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        void IEntityTypeConfiguration<Course_Inst>.Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(i => new { i.Course_Id, i.Inst_Id });
        }
    }
}
