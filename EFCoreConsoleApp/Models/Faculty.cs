namespace EFCoreConsoleApp.Models;

public class Faculty
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int BuildingId { get; set; }
    public Building? Building { get; set; }

    public ICollection<Department> Departments { get; set; } = new List<Department>();
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}