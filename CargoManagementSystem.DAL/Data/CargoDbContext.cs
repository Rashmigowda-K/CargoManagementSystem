using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.DAL.Data
{
    public class CargoDbContext:DbContext
    {
        public CargoDbContext(DbContextOptions<CargoDbContext>options):base(options)
        {

        }
            public DbSet<CargoRegister> Register { get; set; }
        public DbSet<CustomerDetails> customerDetails { get; set; }
        public DbSet<Transaction> transactions { get; set; }

    }
}
