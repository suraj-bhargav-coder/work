using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using Hospita.Models;

namespace Hospita
{
    class HospitaContext:DbContext
    {
        private const string connctionString = "server=MAYANK;Database=HospitaDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connctionString);
        }

        public DbSet<Department> Departments{ get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patetients { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
