using System.Text.Json.Serialization;

namespace ASPNETCoreApp.Models;
public class Location
{
    public int Id { get; set; }
    public int Floor { get; set; }
    public double CeilingHeight { get; set; }
    public int BuildingId { get; set; }
    [JsonIgnore]
    public virtual Building? Building { get; set; }
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
