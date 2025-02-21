using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_Demo.Entities
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        public double Grade {  get; set; } 

        public Student Student { get; set; }
        public Course Course { get; set; }
        
    }
}
