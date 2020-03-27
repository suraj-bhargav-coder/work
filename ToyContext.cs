using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToyCompany.Models;

namespace ToyCompany
{
    class ToyContext:DbContext
    {
        private const string connctionString = "server=MAYANK;Database=ToyCompanyDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connctionString);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Costomers { get; set; }
        public DbSet<Factory> Factory{ get; set; }
        public DbSet<Order> Ordes { get; set; }
        public DbSet<Scheme> Schemes { get; set; }
        public DbSet<Toy> Toys { get; set; }

    }
}
