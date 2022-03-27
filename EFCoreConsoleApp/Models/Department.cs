namespace EFCoreConsoleApp.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
    public ICollection<Laboratory> Laboratories { get; set; } = new List<Laboratory>();
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}