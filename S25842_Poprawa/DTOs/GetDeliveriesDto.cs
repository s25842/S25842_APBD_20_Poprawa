namespace S25842_Poprawa.DTOs;

public class GetDeliveriesDto
{
    public DateTime date{get;set;}
    public CustomerDto customer{get;set;}
    public DriverDto driver{get;set;}
    public List<ProductDto> products{get;set;}
}

public class CustomerDto
{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public DateTime DateOfBirth{get;set;}
    
}
public class DriverDto
{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string LicenseNumber{get;set;}
}

public class ProductDto
{
    public string Name{get;set;}
    public decimal Price{get;set;}
    public int Amount{get;set;}
}