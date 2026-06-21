using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using S25842_Poprawa.Data;
using S25842_Poprawa.DTOs;

namespace S25842_Poprawa.Controllers;
[Route("api/deliveries/{id:int}")]
[ApiController]
public class DeliveriesController :ControllerBase
{
    private readonly AppDbContext _context;

    public DeliveriesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetDeliveriesById(int id)
    {
        var Delivery = await _context.Deliveries.Where(o => o.DeliveryId == id).Select(o=>new GetDeliveriesDto
        {
            date = o.Date,
            customer = new CustomerDto
            {
                FirstName = o.Customer.FirstName,
                LastName = o.Customer.LastName,
                DateOfBirth = o.Customer.DateOfBirth,
            },
            driver = new DriverDto
            {
                FirstName = o.Driver.FirstName,
                LastName = o.Driver.LastName,
                LicenseNumber = o.Driver.LicenseNumber,
            },
            products = o.ProductDeliveries.Select(po => new ProductDto
            {
                Name = po.Product.Name,
                Price = po.Product.Price,
                Amount = po.Amount
                
            }).ToList()
            
        }).FirstOrDefaultAsync();
        return Ok(Delivery);
    }
}