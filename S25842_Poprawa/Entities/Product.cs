using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S25842_Poprawa.Entities;
[Table("Product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = String.Empty;
    [Column(TypeName = "decimal(10,2")]
    public decimal Price { get; set; }
    
    ICollection<ProductDelivery> ProductDelivery { get; set; }
}