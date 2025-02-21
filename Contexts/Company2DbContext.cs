using EF03_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_Demo.Contexts
{
    public class Company2DbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=Company2DB;Trusted_Connection=true;TrustServerCertificate =true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasMany(C => C.CourseStudents)
                                         .WithOne(sc => sc.Course)
                                         .HasForeignKey(sc => sc.CourseID);

            modelBuilder.Entity<Student>().HasMany(S=>S.StudentCourses)
                .WithOne(sc=>sc.Student).HasForeignKey(sc => sc.StudentID);
                
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc=>new {sc.CourseID,sc.StudentID});    
   
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students {  get; set; }

    }
}
