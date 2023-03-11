﻿// <auto-generated />
using System;
using EmployeesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeesApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20230311035852_Making account number field nullable")]
    partial class Makingaccountnumberfieldnullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeesApp.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0745c54d-b969-4a30-b581-4429fb5e78a1"),
                            AccountNumber = "123-3452134543-32",
                            Age = 30,
                            Name = "Mark"
                        },
                        new
                        {
                            Id = new Guid("960df825-ffe5-4873-b828-c6efb80a7785"),
                            AccountNumber = "123-9384613085-55",
                            Age = 28,
                            Name = "Evelin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
