﻿// <auto-generated />
using System;
using EFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    [DbContext(typeof(UniversityRoomFundDbContext))]
    partial class UniversityRoomFundDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreConsoleApp.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Building #1"
                        });
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyId = 1,
                            Name = "Eastern Languages"
                        },
                        new
                        {
                            Id = 2,
                            FacultyId = 1,
                            Name = "Slavic Languages"
                        });
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            Name = "Foreign Languages"
                        });
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<double>("CeilingHeight")
                        .HasColumnType("float");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int?>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("LaboratoryId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            CeilingHeight = 2.5,
                            DepartmentId = 1,
                            FacultyId = 1,
                            Length = 13.5,
                            Location = "Somewhere",
                            Number = 404,
                            Purpose = "Research",
                            Type = "Normal",
                            Width = 28.0
                        },
                        new
                        {
                            Id = 2,
                            BuildingId = 1,
                            CeilingHeight = 2.5,
                            DepartmentId = 2,
                            FacultyId = 1,
                            Length = 13.5,
                            Location = "Somewhere",
                            Number = 1337,
                            Purpose = "Idk",
                            Type = "Normal",
                            Width = 28.0
                        });
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Department", b =>
                {
                    b.HasOne("EFCoreConsoleApp.Models.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Faculty", b =>
                {
                    b.HasOne("EFCoreConsoleApp.Models.Building", "Building")
                        .WithMany("Faculties")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Laboratory", b =>
                {
                    b.HasOne("EFCoreConsoleApp.Models.Department", "Department")
                        .WithMany("Laboratories")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Room", b =>
                {
                    b.HasOne("EFCoreConsoleApp.Models.Building", "Building")
                        .WithMany("Rooms")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreConsoleApp.Models.Department", "Department")
                        .WithMany("Rooms")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("EFCoreConsoleApp.Models.Faculty", "Faculty")
                        .WithMany("Rooms")
                        .HasForeignKey("FacultyId");

                    b.HasOne("EFCoreConsoleApp.Models.Laboratory", "Laboratory")
                        .WithMany("Rooms")
                        .HasForeignKey("LaboratoryId");

                    b.Navigation("Building");

                    b.Navigation("Department");

                    b.Navigation("Faculty");

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Building", b =>
                {
                    b.Navigation("Faculties");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Department", b =>
                {
                    b.Navigation("Laboratories");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Faculty", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("EFCoreConsoleApp.Models.Laboratory", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
