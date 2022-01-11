using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ProjectService : IProjectService
    {
        public Task<bool> DeleteProject(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetProjectByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterProject(Project project)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
