using Microsoft.EntityFrameworkCore;

namespace Data.Entities.Projects;

[PrimaryKey("Id")]
public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}