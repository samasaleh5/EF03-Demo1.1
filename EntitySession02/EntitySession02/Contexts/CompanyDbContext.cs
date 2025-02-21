using EntitySession02.Configrations;
using EntitySession02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession02.Contexts
{
    static class SQlTypes
    {
        public static string varChar = "varchar";

    }
    internal class CompanyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server=.;Database=CompanyG012;Trusted_Connection=true;trustservercertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfigrations());
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.Entity<Employee>().HasOne(e => e.Department)
                                           .WithMany(d => d.Employees)
                                           .IsRequired()
                                           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>().HasMany(d => d.Employees)
                                             .WithOne(e => e.Department);

            modelBuilder.Entity<Department>().HasOne(d => d.Employee)
                                              .WithOne(e=>e.ManagedDepartment);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments{ get; set; }

    }
}
