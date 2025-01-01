using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;
public class ProjectUpdate
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }

    [Required]
    [MaxLength(100)]
    public string UpdateTitle { get; set; } = string.Empty;

    [Required]
    public string UpdateBody { get; set; } = string.Empty;

    public DateTime UpdateDate { get; set; } = DateTime.Now;
}
