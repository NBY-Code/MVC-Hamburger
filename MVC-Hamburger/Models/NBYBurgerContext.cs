using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_Hamburger.Models
{
    public partial class NBYBurgerContext : IdentityDbContext<IdentityUser>
    {
        public NBYBurgerContext()
        {
        }

        public NBYBurgerContext(DbContextOptions<NBYBurgerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ExtraMaterial> ExtraMaterials { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrdersExtraMaterial> OrdersExtraMaterials { get; set; } = null!;
        public virtual DbSet<OrdersMenu> OrdersMenus { get; set; } = null!;
        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=NBY-Burger;Trusted_Connection=True;Trust Server Certificate=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExtraMaterial>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Size).HasMaxLength(50);
            });

            modelBuilder.Entity<OrdersExtraMaterial>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ExtraMaterialId });

                entity.HasOne(d => d.ExtraMaterial)
                    .WithMany(p => p.OrdersExtraMaterials)
                    .HasForeignKey(d => d.ExtraMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersExtraMaterials_ExtraMaterials");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersExtraMaterials)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersExtraMaterials_Orders");
            });

            modelBuilder.Entity<OrdersMenu>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.MenuId });

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.OrdersMenus)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersMenus_Menus");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersMenus)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersMenus_Orders");
            });
            AddDummyData(modelBuilder);
            //OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }

        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(

                new Menu { Id = 1, Name = "Cheeseburger", Price = 9.99M, Photo = "f2.png" },
            new Menu { Id = 2, Name = "Chicken burger", Price = 11.99M, Photo = "f8.png" },
            new Menu { Id = 3, Name = "Chicken Cheeseburger", Price = 13.99M, Photo = "f7.png" },
            new Menu { Id = 4, Name = "Pepperoni Pizza", Price = 14.99M, Photo = "f3.png" },
            new Menu { Id = 5, Name = "Margherita Pizza", Price = 12.99M, Photo = "f1.png" },
            new Menu { Id = 6, Name = "Meat Lovers Pizza", Price = 16.99M, Photo = "f6.png" },
            new Menu { Id = 7, Name = "Spaghetti Carbonara", Price = 10.99M, Photo = "f9.png" },
            new Menu { Id = 8, Name = "Special Pasta", Price = 11.99M, Photo = "f4.png" },
            new Menu { Id = 9, Name = "Garlic Fries", Price = 4.99M, Photo = "f5.png" }

            );
            modelBuilder.Entity<ExtraMaterial>().HasData(
                new ExtraMaterial {Id=1,Name="Barbekü",Price=1.00M,Photo= "barberkü.jpeg" },
                new ExtraMaterial {Id=2,Name="Cheddar",Price=1.50M,Photo= "cheddar.jpg" },
                new ExtraMaterial {Id=3,Name= "Crispy Ball", Price=1.50M,Photo= "citirtop.jpeg" },
                new ExtraMaterial {Id=4,Name="Barbeque Sauce",Price=1.00M,Photo= "barberkü.jpeg" },
                new ExtraMaterial {Id=5,Name="Mixed Special",Price=11.00M,Photo= "karisiktabak.jpeg" },
                new ExtraMaterial {Id=6,Name= "Cheddar Filling", Price=5.00M,Photo= "kasardolgu.webp" },
                new ExtraMaterial {Id=7,Name= "Ketchup", Price=1.00M,Photo= "ketcap.jpeg" },
                new ExtraMaterial {Id=8,Name= "Mayonnaise", Price=1.00M,Photo= "mayonez.jpg" },
                new ExtraMaterial {Id=9,Name= "Ranch Sauce", Price=1.00M,Photo= "ranchsos.jpg" },
                new ExtraMaterial {Id=10,Name= "Garlic Mayonnaise", Price=1.00M,Photo= "sarimsaklimayonez.jpg" },
                new ExtraMaterial {Id=11,Name= "Schnitzel", Price=8.75M,Photo= "sinitzel.jpeg" },
                new ExtraMaterial {Id=12,Name= "Sweet Chilli Sauce", Price=1.00M,Photo= "sweetchillisos.jpg" }
                );
        }

        //   partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
