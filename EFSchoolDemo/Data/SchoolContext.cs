using Microsoft.EntityFrameworkCore;
using EFSchoolDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchoolDemo.Data
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=school;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
