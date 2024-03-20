﻿// <auto-generated />
using EFCodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCodeFirstFluentAPI.Migrations
{
    [DbContext(typeof(Northwind))]
    [Migration("20240320073058_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("EFCodeFirst.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Beverages",
                            Description = "Soft drinks, coffees, teas, beers, and ales"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Yanto",
                            Description = "Yanto is human being"
                        });
                });

            modelBuilder.Entity("EFCodeFirst.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint")
                        .HasColumnName("UnitsInStock");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Price = 18,
                            ProductName = "Chai",
                            Stock = (short)39
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Price = 19,
                            ProductName = "Chang",
                            Stock = (short)17
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Price = 10,
                            ProductName = "Aniseed Syrup",
                            Stock = (short)13
                        });
                });

            modelBuilder.Entity("EFCodeFirst.Product", b =>
                {
                    b.HasOne("EFCodeFirst.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFCodeFirst.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
