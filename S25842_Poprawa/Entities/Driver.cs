using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S25842_Poprawa.Entities;

[Table(("Driver"))]
public class Driver
{
    [Key]
    public int DriverId { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    [MaxLength(17)]
    public string LicenseNumber { get; set; }
    
}