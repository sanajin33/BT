using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VT.Data.Entities;

public class Organization
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string ContactEmail { get; set; } = string.Empty;

    [MaxLength(15)]
    [Phone]
    public string ContactPhone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string MissionStatement { get; set; }=string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Project> Projects { get; set; } = [];

}
