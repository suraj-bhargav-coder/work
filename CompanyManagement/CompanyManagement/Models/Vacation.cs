using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyManagement.Models
{
    class Vacation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacationId { get; set; }
        public int Duration { get; set; }

        [ForeignKey(nameof(Employee))]
         public int EmployeeId { get; set;}

        public Vacation()
        {


        }

        public Vacation(int d,  int ei)
        {
            this.Duration = d;
            this.EmployeeId =ei;
           
        }

    }

}
