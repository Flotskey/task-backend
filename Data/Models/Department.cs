using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASPNETCoreApp.Models;

public class Department
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public int FacultyId { get; set; }
    [JsonIgnore]
    public virtual Faculty? Faculty { get; set; }
}