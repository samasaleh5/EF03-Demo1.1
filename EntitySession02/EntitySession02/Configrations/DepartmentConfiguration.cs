using EntitySession02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession02.Configrations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
          
            builder
                        .Property(c => c.Name)
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 50)
            .IsRequired();

            builder
                        .Property(c => c.CreationDate)
                        .HasDefaultValueSql("GetDate()");
        }
    }
}
