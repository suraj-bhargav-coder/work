using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospita.Models
{
    class Treatment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreatmentId { get; set; }
        public string DrugName { get; set; }
        // public string TimeSlot{ get; set; }
        //[ForeignKey(nameof(Doctor))]
        // public int DoctorId { get; set; }

        [ForeignKey(nameof(Appointment))]
         public int AppointmentId { get; set; }


        public Treatment()
        {
            
        }

        
        public Treatment (string DN, int AI)
        {
            this.DrugName = DN;

            this.AppointmentId = AI;

            
        }
    }
}
