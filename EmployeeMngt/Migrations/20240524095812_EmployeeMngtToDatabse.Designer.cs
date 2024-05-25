﻿// <auto-generated />
using System;
using EmployeeMngt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeMngt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240524095812_EmployeeMngtToDatabse")]
    partial class EmployeeMngtToDatabse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Adress_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Adress_Id"));

                    b.Property<Guid>("Employee_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Employee_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Adress_Id");

                    b.HasIndex("Employee_Id")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Employee_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DepartmentId");

                    b.HasIndex("Employee_Id")
                        .IsUnique();

                    b.ToTable("Department");
                });

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Employee_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Address", b =>
                {
                    b.HasOne("EmployeeMngt.Domain.Entities.Employee", "Employee")
                        .WithOne("Employee_address")
                        .HasForeignKey("EmployeeMngt.Domain.Entities.Address", "Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Department", b =>
                {
                    b.HasOne("EmployeeMngt.Domain.Entities.Employee", "Employee")
                        .WithOne("Employee_Department")
                        .HasForeignKey("EmployeeMngt.Domain.Entities.Department", "Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeMngt.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Employee_Department")
                        .IsRequired();

                    b.Navigation("Employee_address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
