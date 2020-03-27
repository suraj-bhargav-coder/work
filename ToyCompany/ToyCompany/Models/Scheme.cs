using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyCompany.Models
{
    class Scheme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchemeId { get; set; }
        public string SchemeName { get; set; }

        public string SchemeDescription { get; set; }
        public int OfferAmount {get;set;}



        public Scheme()
        {
           
        }

        public Scheme(string sn , string sd,int oa)
        {
            this.SchemeName = sn ;
            this.SchemeDescription = sd ;
            this.OfferAmount = oa ;
        }





    }
}
