using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        public Task<bool> DeleteProjectType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectType>> GetAllProjectTypes()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectType> GetProjectTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectType>> GetProjectTypeByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterProjectType(ProjectType projectType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectType(ProjectType projectType)
        {
            throw new NotImplementedException();
        }
    }
}
