using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IProjectTypeService
    {
        Task<bool> RegisterProjectType(ProjectType projectType);
        Task<List<ProjectType>> GetAllProjectTypes();
        Task<List<ProjectType>> GetProjectTypeByName(string filter);
        Task<ProjectType> GetProjectTypeById(int id);
        Task<bool> UpdateProjectType(ProjectType projectType);
        Task<bool> DeleteProjectType(int id);
    }
}
