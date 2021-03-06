﻿using Alza.Common.Entities;
using Microsoft.EntityFrameworkCore;


namespace Alza.Data.MSSQLData
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public ProductDBContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
           .HasOne<Inventory>(i => i.ProductInventory)
           .WithOne(p => p.OwnedProduct)
           .HasForeignKey<Inventory>(i => i.ProductId);

            modelBuilder.Entity<Inventory>()
             .Property(f => f.Id)
             .ValueGeneratedOnAdd();

            modelBuilder.Seed();
        }
    }
}
