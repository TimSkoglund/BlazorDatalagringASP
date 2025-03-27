using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities.Customers;

[PrimaryKey("Id")]
public class Customer
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}