using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MSI1S2I; database=CoreApp;integrated security=true;");
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Tv> Tvs { get; set; }

    }
}
