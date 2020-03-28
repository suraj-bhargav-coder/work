using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyManagement.Models
{
    class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string    Mobile { get; set; }


        //[ForeignKey(nameof(Toy))]
        //  public int ToyId { get; set; }

        public Employee()
        {


        }

        public Employee(string en, string d ,string e, string m)
        {
            this.EmployeeName = en;
            this.Designation = d;
            this.Email = e;
            this.Mobile = m;
        }

    }
}
