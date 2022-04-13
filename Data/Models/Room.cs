using ASPNETCoreApp.Enums;
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

    public int LocationId { get; set; }
    [JsonIgnore]
    public virtual Location? Location { get; set; }

    public int? DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
}
