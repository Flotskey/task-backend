namespace EFCoreConsoleApp.Models;

public class Laboratory
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}