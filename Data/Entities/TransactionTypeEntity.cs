using System.ComponentModel.DataAnnotations;


namespace Data.Entities;

public class TransactionTypeEntity
{
    [Key]
    public int TransactionTypeId { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; } = null!;

    [MaxLength(255)]
    public string Description { get; set; } = null!;
}