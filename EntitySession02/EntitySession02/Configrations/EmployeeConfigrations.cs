using EntitySession02.Contexts;
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
    internal class EmployeeConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //builder.Property("Address")
            //                      .HasColumnType(SQlTypes.varChar)
            //                      .HasMaxLength(50)
            //                      .IsRequired()/*;*/
        }
    }
}
