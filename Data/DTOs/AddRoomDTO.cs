using ASPNETCoreApp.Enums;

namespace ASPNETCoreApp.DTOs;

public class AddRoomDTO
{
    public int Number { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public RoomPurpose Purpose { get; set; } = RoomPurpose.Study;
    public RoomType Type { get; set; } = RoomType.Basic;
    public int LocationId { get; set; }
    public int? DepartmentId { get; set; }
}
 