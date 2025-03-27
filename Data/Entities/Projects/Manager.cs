using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities.Projects;

[PrimaryKey("Id")]
public class Manager
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int HourPrice { get; set; }
}