using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace S25842_Poprawa.Entities;

[Table("ProductDelivery")]
[PrimaryKey(nameof(ProductDelivery),nameof(Delivery))]
public class ProductDelivery
{
    public int ProductId { get; set; }
    public int DeliveryId { get; set; }
    public int Amount { get; set; }
    
    
    
    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; }
    [ForeignKey(nameof(DeliveryId))]
    public Delivery Delivery { get; set; }
}