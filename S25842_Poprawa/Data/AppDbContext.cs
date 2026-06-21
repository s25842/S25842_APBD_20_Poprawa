using Microsoft.EntityFrameworkCore;
using S25842_Poprawa.Entities;

namespace S25842_Poprawa.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDelivery> ProductDeliveries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>
        {
            new Customer
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2023, 5, 15)
            },
            new Customer
            {
                CustomerId = 2,
                FirstName = "Johne",
                LastName = "Dose",
                DateOfBirth = new DateTime(2023, 5, 15)
            },
            new Customer
            {
                CustomerId = 3,
                FirstName = "Johun",
                LastName = "Daoe",
                DateOfBirth = new DateTime(2023, 5, 15)
            }
        });
        modelBuilder.Entity<Delivery>().HasData(new List<Delivery>
        {
            new Delivery
            {
                DeliveryId = 1,
                CustomerId = 1,
                DriverId = 1,
                Date = new DateTime(2023, 5, 15)
            },
            new Delivery
            {
                DeliveryId = 2,
                CustomerId = 2,
                DriverId = 2,
                Date = new DateTime(2023, 5, 15)
            },
            new Delivery
            {
                DeliveryId = 3,
                CustomerId = 3,
                DriverId = 3,
                Date = new DateTime(2023, 5, 15)
            }
        });
        modelBuilder.Entity<Driver>().HasData(new List<Driver>
        {
            new Driver
            {
                DriverId = 1,
                FirstName = "John",
                LastName = "Do333",
                LicenseNumber = "ss24252525"
            },
            new Driver
            {
                DriverId = 2,
                FirstName = "Johnsd",
                LastName = "Do33355",
                LicenseNumber = "ss2"
            },
            new Driver
            {
                DriverId = 3,
                FirstName = "Johni",
                LastName = "Do3a33",
                LicenseNumber = "s"
            }
        });
        modelBuilder.Entity<ProductDelivery>().HasData(new List<ProductDelivery>
        {
            new ProductDelivery
            {
                ProductId = 1,
                DeliveryId = 1,
                Amount = 2
            },
            new ProductDelivery
            {
                ProductId = 2,
                DeliveryId = 2,
                Amount = 3
            },
            new ProductDelivery
            {
                ProductId = 3,
                DeliveryId = 3,
                Amount = 1
            }
        });
        modelBuilder.Entity<Product>().HasData(new List<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "sss",
                Price = 2
            },
            new Product
            {
                ProductId = 2,
                Name = "sss",
                Price = 2
            },
            new Product
            {
                ProductId = 3,
                Name = "sss",
                Price = 2
            }
        });

    }
}