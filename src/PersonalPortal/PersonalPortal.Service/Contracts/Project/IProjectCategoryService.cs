using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IProjectCategoryService
    {
        Task<bool> RegisterProjectCategory(ProjectCategory projectCategory);
        Task<List<ProjectCategory>> GetAllProjectCategories();
        Task<List<ProjectCategory>> GetProjectCategoryByName(string filter);
        Task<ProjectCategory> GetProjectCategoryById(int id);
        Task<bool> UpdateProjectCategory(ProjectCategory projectCategory);
        Task<bool> DeleteProjectCategory(int id);
    }
}
