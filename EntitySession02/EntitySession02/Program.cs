using EntitySession02.Contexts;
using EntitySession02.Models;
using Microsoft.EntityFrameworkCore;

namespace EntitySession02
{
    internal class Program
    {
        static void Main(string[] args)
        {


          using CompanyDbContext dbContext = new CompanyDbContext();

            var Department = (from D in dbContext.Departments.Include(D => D.Employee)
                              where D.Id == 10
                              select D).FirstOrDefault();
            //Explicit loading
            //dbContext.Entry(Department).Collection(D => D.Employees).Load();
            //Console.WriteLine($"DepatId={Department.Id} , DeptName={Department.Name}");

            //Eager loading
            //lazy loading


            foreach (var E in Department.Employees)
                Console.WriteLine(E.Name);

            //var Employee = (from E in dbContext.Employees.Include(E=>E.Department)
            //                where E.Id == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine($"{Employee.Id},{Employee.Name}");
            //dbContext.Entry(Employee).Reference(e=>e.Department).Load();
            //Console.WriteLine(Employee.Department.Name);
        }
    }
}
