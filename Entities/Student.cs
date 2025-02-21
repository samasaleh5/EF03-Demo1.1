using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_Demo.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; } 

        public ICollection<StudentCourse> StudentCourses { get; set; }=new HashSet<StudentCourse>();
    }
}
