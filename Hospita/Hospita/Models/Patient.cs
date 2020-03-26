using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospita.Models
{
    class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public int Contect { get; set; }


        public Patient()
        {
            
        }

        public Patient(string pn, int a, int c)
        {
            this.PatientName = pn;

            this.Age = a;

            this.Contect = c;
        }
    }
}
