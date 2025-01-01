using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;

public class VolunteerApplication
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public User? User { get; set; }
    
    public int TaskId { get; set; }
    public VolunteerTask? Task { get; set; }
    
    public DateTime ApplicationDate { get; set; } = DateTime.Now;

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
}

public enum ApplicationStatus
{
    Pending,
    Approved,
}