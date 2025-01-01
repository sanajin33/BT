using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;
public class Notification
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public virtual User? User { get; set; }

    [Required]
    public string Message { get; set; }=string.Empty;

    public bool IsRead { get; set; } = false;

    [Required]
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}