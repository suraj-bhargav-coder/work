using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyCompany.Models
{
    class Factory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FactoryId { get; set; }
        public string FactortName { get; set; }
        public string City { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }


        [ForeignKey(nameof(Toy))]
         public int ToyId { get; set; }



        public Factory()
        {
            
        }


        public Factory(string fn ,string c,int di, int ci, int ti)
        {
            this.FactortName = fn;

            this.City = c;

            this.CategoryId = ci;

            this.ToyId = ti;
        }




    }
}
