using Microsoft.EntityFrameworkCore;
using EFCoreConsoleApp.Models;

namespace EFCoreConsoleApp;

public class UniversityRoomFundDbContext : DbContext
{
    public DbSet<Building>? Buildings { get; set; }
    public DbSet<Room>? Rooms { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Faculty>? Faculties { get; set; }
    public DbSet<Laboratory>? Laboratories { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options
            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=class_room_fund;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Building>().HasData(new Building() { Id = 1, Name = "Building #1" });
        builder.Entity<Faculty>().HasData(new Faculty() { Id = 1, Name = "Foreign Languages", BuildingId = 1 });
        builder.Entity<Department>().HasData(new Department() { Id = 1, Name = "Eastern Languages", FacultyId = 1 });
        builder.Entity<Department>().HasData(new Department() { Id = 2, Name = "Slavic Languages", FacultyId = 1 });

        builder.Entity<Room>().HasData(new Room()
        {
            Id = 1,
            BuildingId = 1,
            FacultyId = 1,
            DepartmentId = 1,
            Number = 404,
            Length = 13.5,
            Width = 28,
            Location = "Somewhere",
            Purpose = "Research",
            Type = "Normal",
            CeilingHeight = 2.5
        });
        builder.Entity<Room>().HasData(new Room()
        {
            Id = 2,
            BuildingId = 1,
            FacultyId = 1,
            DepartmentId = 2,
            Number = 1337,
            Length = 13.5,
            Width = 28,
            Location = "Somewhere",
            Purpose = "Idk",
            Type = "Normal",
            CeilingHeight = 2.5
        });
    }
}