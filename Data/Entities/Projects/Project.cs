using Microsoft.EntityFrameworkCore;

namespace Data.Entities.Projects;

[PrimaryKey("Id")]
public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }
}