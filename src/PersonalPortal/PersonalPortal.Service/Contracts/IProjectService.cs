using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IProjectService
    {
        Task<bool> RegisterProject(Project project);
        Task<List<Project>> GetAllProjects();
        Task<List<Project>> GetProjectByName(string filter);
        Task<Project> GetProjectById(int id);
        Task<bool> UpdateProject(Project project);
        Task<bool> DeleteProject(int id);
    }
}
