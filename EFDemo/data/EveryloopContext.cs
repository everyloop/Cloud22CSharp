using Microsoft.EntityFrameworkCore;
using EFDemo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.data;

class EveryloopContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=everyloop;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
   
