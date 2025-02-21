using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_Demo.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<StudentCourse> CourseStudents { get; set; }=new HashSet<StudentCourse>();
    }
}
