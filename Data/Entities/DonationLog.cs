using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VT.Data.Entities;

public class DonationLog
{
    public int Id { get; set; }

    public int? DonationId { get; set; }
    public virtual Donation? Donation { get; set; }

    public string LogMessage { get; set; } = string.Empty;

    public DateTime LogDate { get; set; } = DateTime.UtcNow; 
}
