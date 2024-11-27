using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsManagementSystem.Infrastructure.Models;

[Table("News")]
public class NewsDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    [StringLength(256)]
    public string Image { get; set; }

    [StringLength(1000)]
    public string? Title { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
