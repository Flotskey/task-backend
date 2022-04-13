using Microsoft.EntityFrameworkCore;
using ASPNETCoreApp.Models;

namespace ASPNETCoreApp;

public class UniversityRoomFundDbContext : DbContext
{
    public DbSet<Building>? Buildings { get; set; }
    public DbSet<Location>? Locations { get; set; }
    public DbSet<Faculty>? Faculties { get; set; }
    public DbSet<Department>? Departments { get; set; }
    public DbSet<Room>? Rooms { get; set; }

    public UniversityRoomFundDbContext()
    {
        /*Database.EnsureDeleted();
        Database.EnsureCreated();*/
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=university_room_fund;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        _ = new DataSeeder(builder);
    }
}