using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace VT.Data.Entities;

public class Donation
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }

    public decimal Amount { get; set; }

    public DateTime DonationDate { get; set; } = DateTime.UtcNow;

    [MaxLength(512)]
    public string? Notes { get; set; }

    public ICollection<DonationItem> Items { get; set; } = [];
    public ICollection<DonationLog> Logs { get; set; } = [];
}