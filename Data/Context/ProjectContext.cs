using Data.Entities.Customers;
using Data.Entities.Projects;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class ProjectContext: DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Manager> Manager { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Service> Service { get; set; }

    public string DbPath { get; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    public ProjectContext()
    {
        var currentDir = Directory.GetCurrentDirectory();

        var projectDir = Path.GetFullPath(Path.Combine(currentDir, ".."));
        DbPath = Path.Join(projectDir, "project.db");
    }
}