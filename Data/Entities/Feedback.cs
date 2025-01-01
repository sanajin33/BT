using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VT.Data.Entities;
public class Feedback
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public int OrganizationId { get; set; }
    public virtual Organization? Organization { get; set; }

    public int Rating { get; set; }

    public string Comments { get; set; }=string.Empty;

    public DateTime FeedbackDate { get; set; } = DateTime.UtcNow;

}
