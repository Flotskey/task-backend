using ASPNETCoreApp.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ASPNETCoreApp.Models;

public class Room
{
    public int Id { get; set; }
    public int Number { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public RoomPurpose Purpose { get; set; } = RoomPurpose.Study;
    public RoomType Type { get; set; } = RoomType.Basic;
    public double Area { get; set; }
    public int LocationId { get; set; }
    [JsonIgnore]
    public Location? Location { get; set; }

    public int? DepartmentId { get; set; }
    [JsonIgnore]
    public Department? Department { get; set; }
}
