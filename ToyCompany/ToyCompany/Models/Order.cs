using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyCompany.Models
{
    class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Customer))]
        public int ToyId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }


        public Order()
        {
            

        }
        public Order(int ti, int q , int ci) {
            this.ToyId = ti ;
            this.Quantity = q ;
            this.CustomerId =  ci;

        }

    }
}
