using Data.Entities.Projects;

namespace Data.Repositories.Interfaces;

public interface IProjectRepository
{
    Task<int> Create(Project project, CancellationToken cancellationToken);
    Task<Project> GetProjectByProjectId(int projectId, CancellationToken cancellationToken);
    Task<List<Project>> GetProjects(CancellationToken cancellationToken);
    Task Update(Project project, CancellationToken cancellationToken);
    Task Delete(int projectId, CancellationToken cancellationToken);
}