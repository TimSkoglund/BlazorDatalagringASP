using Data.Context;
using Data.Entities.Projects;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ProjectRepository : IProjectRepository

{
    private readonly BlazorDatalagringContext _databaseContext;

    public ProjectRepository(BlazorDatalagringContext context)
    {
        _databaseContext = context;
    }
    public async Task<int> Create(Project project, CancellationToken cancellationToken)
    {
        await _databaseContext.AddAsync(project);
        return await _databaseContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Project> GetProjectByProjectId(int projectId, CancellationToken cancellationToken)
    {
        var project = await _databaseContext.Project.FindAsync(projectId, cancellationToken);
        return project;
    }

    public async Task<List<Project>> GetProjects(CancellationToken cancellationToken)
    {
        var projects = await _databaseContext.Project.ToListAsync(cancellationToken);
        return projects ?? new();
    }

    public async Task Delete(int projectId, CancellationToken cancellationToken)
    {
        var project = await GetProjectByProjectId(projectId, cancellationToken);
        _databaseContext.Project.Remove(project);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Update(Project project, CancellationToken cancellationToken)
    {
        _databaseContext.Project.Update(project);
        await _databaseContext.SaveChangesAsync(cancellationToken);
    }
}