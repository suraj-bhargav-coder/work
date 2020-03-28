using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyManagement.Models
{
    class AssignProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    AssignProjectId { get; set; }
        public string EmployeeRole{ get; set; }

        [ForeignKey(nameof(Employee))]
         public int    EmployeeId { get; set; }

        [ForeignKey(nameof(Project))]
        public int    ProjectId { get; set; }

        public AssignProject()
        {


        }

        public AssignProject(string er, int ei, int pi)
        {
            this.EmployeeRole =er;
            this.EmployeeId =ei;
            this.ProjectId = pi;
        }





    }
}
