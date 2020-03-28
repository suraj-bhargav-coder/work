using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyManagement.Models
{
    class BusinessUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessDescription { get; set; }
        public string UnitLocation { get; set; }


        public BusinessUnit()
        {


        }

        public BusinessUnit(string bun, string bd, string ul)
        {
            this.BusinessUnitName = bun;
            this.BusinessDescription = bd;
            this.UnitLocation = ul;
        }

    }
}
