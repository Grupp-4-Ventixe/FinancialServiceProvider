using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class StatusEntity
{
    [Key]
    public int StatusId { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; } = null!;

    [MaxLength(255)]
    public string Description { get; set; } = null!;
}
