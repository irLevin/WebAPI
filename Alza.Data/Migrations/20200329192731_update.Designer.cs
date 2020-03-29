﻿// <auto-generated />
using Alza.Data.MSSQLData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alza.Data.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    [Migration("20200329192731_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alza.Data.MSSQLData.Models.Inventory", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("ProductId");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            ProductId = 100001,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ProductId = 100002,
                            UnitsInStock = 300
                        },
                        new
                        {
                            ProductId = 100003,
                            UnitsInStock = 5
                        },
                        new
                        {
                            ProductId = 100004,
                            UnitsInStock = 0
                        },
                        new
                        {
                            ProductId = 100005,
                            UnitsInStock = 0
                        },
                        new
                        {
                            ProductId = 100006,
                            UnitsInStock = 50
                        },
                        new
                        {
                            ProductId = 100007,
                            UnitsInStock = 100
                        });
                });

            modelBuilder.Entity("Alza.Data.MSSQLData.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 100001,
                            Description = "Product 100001 description",
                            ImgUrl = "http://img.com/100001.jps",
                            Name = "Product 100001",
                            Price = 20.5m
                        },
                        new
                        {
                            Id = 100002,
                            Description = "Product 100002 description",
                            ImgUrl = "http://img.com/100002.jps",
                            Name = "Product 100002",
                            Price = 12.5m
                        },
                        new
                        {
                            Id = 100003,
                            Description = "Product 100003 description",
                            ImgUrl = "http://img.com/100003.jps",
                            Name = "Product 100003",
                            Price = 10m
                        },
                        new
                        {
                            Id = 100004,
                            Description = "Product 100004 description",
                            ImgUrl = "http://img.com/100004.jps",
                            Name = "Product 100004",
                            Price = 16m
                        },
                        new
                        {
                            Id = 100005,
                            Description = "Product 100005 description",
                            ImgUrl = "http://img.com/100005.jps",
                            Name = "Product 100005",
                            Price = 9.5m
                        },
                        new
                        {
                            Id = 100006,
                            Description = "Product 100006 description",
                            ImgUrl = "http://img.com/100006.jps",
                            Name = "Product 100006",
                            Price = 30m
                        },
                        new
                        {
                            Id = 100007,
                            Description = "Product 100007 description",
                            ImgUrl = "http://img.com/100007.jps",
                            Name = "Product 100007",
                            Price = 40m
                        });
                });

            modelBuilder.Entity("Alza.Data.MSSQLData.Models.Inventory", b =>
                {
                    b.HasOne("Alza.Data.MSSQLData.Models.Product", "OwnedProduct")
                        .WithOne("ProductInventory")
                        .HasForeignKey("Alza.Data.MSSQLData.Models.Inventory", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}