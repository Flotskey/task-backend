using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETCoreApp.Models;

public class Building
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Location>? Locations { get; set; } = new List<Location>();
    public virtual ICollection<Faculty>? Faculties { get; set; } = new List<Faculty>();
}