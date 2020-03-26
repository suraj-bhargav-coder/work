using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospita.Models
{
    class Doctor
    {
        private int di;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }

        public string Designation { get; set; }

        //[ForeignKey(nameof(Department))] 
        ///public int DepartmentId { get; set; }


        public Doctor()
        {

        }

        public Doctor(string dn, string d)
        {
            this.DoctorName = dn;

            this.Designation= d;

            


           

        }
    }
}
