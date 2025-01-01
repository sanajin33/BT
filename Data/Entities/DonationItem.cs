using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BT.Data.Entities;

public class DonationItem
{
    public int Id { get; set; }

    public int DonationId { get; set; }
    public virtual Donation? Donation { get; set; }

    public int CategoryId { get; set; }
    public virtual DonationCategory? Category { get; set; }

    [Required]
    [MaxLength(100)] 
    public string ItemName { get; set; } = string.Empty;

    public int Quantity { get; set; }

    [MaxLength(512)]
    public string? Notes { get; set; } 
}
