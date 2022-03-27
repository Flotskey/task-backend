namespace EFCoreConsoleApp.Models;

public class Room
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Location { get; set; } = string.Empty;
    public double Width { get; set; }
    public double Length { get; set; }
    public double CeilingHeight { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;

    public int BuildingId { get; set; }
    public Building? Building { get; set; }

    public int? FacultyId { get; set; }
    public Faculty? Faculty { get; set; }

    public int? DepartmentId { get; set; }
    public Department? Department { get; set; }

    public int? LaboratoryId { get; set; }
    public Laboratory? Laboratory { get; set; }
}
