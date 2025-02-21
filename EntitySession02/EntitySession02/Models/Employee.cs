using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession02.Models
{
   
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The Name is Required! ") ]
        public string Name { get; set; }

        public decimal Salary { get; set; }
        [Range(22,60)]
        public int? Age { get; set; }

        [NotMapped]
        public decimal NetSalary { get; set; }

        public decimal GetNetSalary => Salary * 0.2m;

        [ForeignKey("Department")]
        public int? HamadaId   { get; set; }

        [InverseProperty("Employees")]
       public  virtual Department Department { get; set; }
        [InverseProperty("Employee")]
       public virtual Department ManagedDepartment { get; set; }
    }
}
