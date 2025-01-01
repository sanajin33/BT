using Microsoft.AspNetCore.Identity;

namespace VT.Data.Entities;

public class User : IdentityUser<int>
{
    public string Name { get; set; }=string.Empty;
    public string Address { get; set; } = string.Empty;
    public UserType UserType { get; set; } = UserType.Volunteer;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<Notification> Notifications { get; set; } = [];
    public ICollection<VolunteerTask> VolunteerTasks { get; set; } = [];
    public ICollection<Organization> Organizations { get; set; } = [];
    public ICollection<VolunteerApplication> VolunteerApplications { get; set; } = [];
}

public enum UserType
{
    Admin,
    Donor,
    Organization,
    Volunteer,
}