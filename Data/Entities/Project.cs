using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;
public class Project
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }
    public virtual Organization? Organization { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public ProjectStatus Status { get; set; } = ProjectStatus.Pending;

    public ICollection<ProjectUpdate> ProjectUpdates { get; set; } = [];
    public ICollection<VolunteerTask> VolunteerTask { get; set; } = [];

}

public enum ProjectStatus
{
    Ongoing,
    Completed,
    Pending,
}