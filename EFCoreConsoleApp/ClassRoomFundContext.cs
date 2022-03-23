using Microsoft.EntityFrameworkCore;
using namespace EFCoreConsoleApp.Models;

namespace EFCoreConsoleApp;

public class UniversityRoomFundDbContext : DbContext
{
    public DbSet<Building> Buildings { get; set; }
    public DbSet<Room> Rooms { get; set; } 

    protected void OnConfiguring(DbContextOptionsBuilder<UniversityRoomFundDbContext> options)
    {
        options.UseSqlServer();
    }
}