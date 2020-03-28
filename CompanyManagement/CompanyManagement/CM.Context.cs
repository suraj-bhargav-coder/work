using CompanyManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManagement
{
        class CM : DbContext
        {
            private const string connctionString = "server=MAYANK;Database=CompanyManagementDb;Trusted_Connection=True;";

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(connctionString);
            }

            public DbSet<AssignProject> Assignprojects { get; set; }
            public DbSet<BusinessUnit>BusinessUnits { get; set; }
            public DbSet<Employee>Employees { get; set; }     
            public DbSet<Project>Projects { get; set; }
            public DbSet<Vacation> Vacations { get; set; }

    }
    

}
