using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Data.Entities;

public class TransactionEntity
{
    [Key]
    public int TransactionId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required, MaxLength(100)]
    public string Event { get; set; } = null!;

    [Required]
    public decimal Amount { get; set; }

    [MaxLength(255)]
    public string Note { get; set; } = null!;

    [Required]
    public int StatusId { get; set; }

    [ForeignKey("StatusId")]
    public StatusEntity Status { get; set; } = null!;

    [Required]
    public int TransactionTypeId { get; set; }

    [ForeignKey("TransactionTypeId")]
    public TransactionTypeEntity TransactionTypeEntity { get; set; } = null!;
}