using Data.Entities.Projects;
using Data.Repositories.Interfaces;

namespace Data.Repositories;

public class ProjectRepository : IProjectRepository
{
    public Task<int> Create(Project project, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetProjectByProjectId(int projectId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<Project>> GetProjects(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task IProjectRepository.Delete(int projectId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task IProjectRepository.Update(Project project, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}