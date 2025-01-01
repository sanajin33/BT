using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;
public class VolunteerTask
{
    public int Id { get; set; }
    
    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }
    
    public int UserId { get; set; }
    public virtual User? User { get; set; }
    
    public string Description { get; set; } = string.Empty;
    
    public DateTime Date { get; set; } = DateTime.Now;

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
}

public enum TaskStatus
{
    Ongoing,
    Completed,
    Pending,
}