using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyManagement.Models
{
    class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int    ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Discription { get; set; }
        
        [ForeignKey(nameof(BusinessUnit))]
        public int    BusinessUnitId { get; set; }

        public Project()
        {


        }

        public Project(string pn, string d, int bui)
        {
            this.ProjectName = pn;
            this.Discription = d;
            this.BusinessUnitId = bui;
        }


    }
}
