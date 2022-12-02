using System;
using System.Collections.Generic;
using EFScaffoldingDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFScaffoldingDemo.Data;

public partial class EveryloopContext : DbContext
{
    public EveryloopContext()
    {
    }

    public EveryloopContext(DbContextOptions<EveryloopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=localhost;Database=everyloop;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Finnish_Swedish_CI_AS");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Categories");

            entity.ToTable("categories", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Customers");

            entity.ToTable("customers", "company");

            entity.Property(e => e.Id).HasMaxLength(10);
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTitle).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Employees");

            entity.ToTable("employees", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.BirthDate).HasMaxLength(10);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Country).HasMaxLength(10);
            entity.Property(e => e.Extension).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.HireDate).HasMaxLength(10);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.PhotoPath).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(13);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TitleOfCourtesy).HasMaxLength(10);
        });

        modelBuilder.Entity<EmployeeTerritory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EmployeeTerritory");

            entity.ToTable("employee_territory", "company");

            entity.Property(e => e.Id).HasMaxLength(7);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeeTerritory_Employees");

            entity.HasOne(d => d.Territory).WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.TerritoryId)
                .HasConstraintName("FK_EmployeeTerritory_Territories");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Orders");

            entity.ToTable("orders", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CustomerId).HasMaxLength(10);
            entity.Property(e => e.OrderDate).HasMaxLength(10);
            entity.Property(e => e.RequiredDate).HasMaxLength(10);
            entity.Property(e => e.ShipAddress).HasMaxLength(100);
            entity.Property(e => e.ShipCity).HasMaxLength(50);
            entity.Property(e => e.ShipCountry).HasMaxLength(50);
            entity.Property(e => e.ShipName).HasMaxLength(100);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(20);
            entity.Property(e => e.ShipRegion).HasMaxLength(50);
            entity.Property(e => e.ShippedDate).HasMaxLength(10);

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Orders_Employees");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OrderDetails");

            entity.ToTable("order_details", "company");

            entity.Property(e => e.Id).HasMaxLength(10);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderDetails_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderDetails_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Products");

            entity.ToTable("products", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Regions");

            entity.ToTable("regions", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RegionDescription).HasMaxLength(20);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Suppliers");

            entity.ToTable("suppliers", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactTitle).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.HomePage).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(50);
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Territories");

            entity.ToTable("territories", "company");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TerritoryDescription).HasMaxLength(50);

            entity.HasOne(d => d.Region).WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_Territories_Regions");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
