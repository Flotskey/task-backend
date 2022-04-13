using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETCoreApp.Models;

public class Faculty
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public int BuildingId { get; set; }
    [JsonIgnore]
    public virtual Building? Building { get; set; }
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}