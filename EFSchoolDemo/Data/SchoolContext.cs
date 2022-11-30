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
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=school;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToView("People");
            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = "C#", TeacherName = "Fredrik Johansson" });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 2, Name = "Databaser", TeacherName = "Fredrik Johansson" });

            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 1, StudentId = 1, Score = 3.1f });
            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 1, StudentId = 2, Score = 2.2f });
            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 1, StudentId = 3, Score = 4.3f });
            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 2, StudentId = 1, Score = 3.4f });
            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 2, StudentId = 2, Score = 2.4f });
            modelBuilder.Entity<Grade>().HasData(new Grade { CourseId = 2, StudentId = 3, Score = 4.5f });
        }
    }
}

