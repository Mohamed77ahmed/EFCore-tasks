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
    internal class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        void IEntityTypeConfiguration<Topic>.Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey (t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired().HasColumnType("varchar(20)");

          
           


        }
    }
}
