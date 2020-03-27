using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyCompany.Models
{
    class Toy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    ToyId { get; set; }
        public string ToyName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }




        public Toy()
        {
            

        }

        public Toy(string tn,string d,int p,int ci)
        {
            this.ToyName =  tn;
            this.Description =d  ;
            this.Price = p ;
            this.CategoryId = ci;

        }

    }
}
