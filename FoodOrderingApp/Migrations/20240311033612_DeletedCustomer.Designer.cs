﻿// <auto-generated />
using FoodOrderingApp.DB_Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodOrderingApp.Migrations
{
    [DbContext(typeof(FoodOrderingContext))]
    [Migration("20240311033612_DeletedCustomer")]
    partial class DeletedCustomer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodOrderingApp.Models.OrderMenu", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<bool>("Coffee")
                        .HasColumnType("bit");

                    b.Property<bool>("Hamburger")
                        .HasColumnType("bit");

                    b.Property<bool>("HotDog")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pizza")
                        .HasColumnType("bit");

                    b.Property<bool>("Soda")
                        .HasColumnType("bit");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<bool>("Tea")
                        .HasColumnType("bit");

                    b.HasKey("OrderId");

                    b.ToTable("OrderMenus");
                });
#pragma warning restore 612, 618
        }
    }
}
