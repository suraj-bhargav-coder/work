using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospita.Models
{
    class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepertmentId { get; set; }
        public string DepartmentName { get; set; }


        public Department()
        {
            

        }

        
        public Department(string DN)
        {
            this.DepartmentName = DN;

        }




    }
}
