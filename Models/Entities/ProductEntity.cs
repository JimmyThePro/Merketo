using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Merketo.Models.Entities;

public class ProductEntity
{
    [Key]
    public string ArticleNumber { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Price { get; set; }
    public string? ImageName { get; set; }

    public ICollection<ProductTagEntity> Tags { get; set; } = new HashSet<ProductTagEntity>();
}
