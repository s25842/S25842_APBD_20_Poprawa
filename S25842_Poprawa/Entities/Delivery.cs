using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S25842_Poprawa.Entities;

[Table("Delivery")]
public class Delivery
{
    [Key]
    public int DeliveryId { get; set; }
    public int CustomerId { get; set; }
    public int DriverId { get; set; }
    
    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    public ICollection<ProductDelivery> ProductDeliveries { get; set; } = [];
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; }
    [ForeignKey(nameof(DriverId))]
    public Driver Driver { get; set; }
    
    
    
}