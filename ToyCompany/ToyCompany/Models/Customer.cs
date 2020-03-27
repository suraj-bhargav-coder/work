using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyCompany.Models
{
    class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int Mobile{ get; set; }
        public string Password { get; set; }



        public Customer()
        {
            
        }

        public Customer(string cn,string e, int m,string  p)
        {
            this.CustomerName = cn ;
            this.Email = e ;
            this.Mobile = m ;
            this.Password = p ;
        }

    }
}
