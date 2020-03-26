using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospita.Models
{
    class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }
       
        
        [ForeignKey(nameof(Patient))]
        public int PatetientId { get; set; }


        public Appointment()
        {

        }

        public Appointment(int di, int Dri, int p)
        {
            this.DepartmentId = di;

            this.DoctorId = Dri;

            this.PatetientId = p;
        }
    }
}
