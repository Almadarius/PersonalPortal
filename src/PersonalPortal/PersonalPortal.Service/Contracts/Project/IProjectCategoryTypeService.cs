using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IProjectCategoryTypeService
    {
        Task<bool> RegisterProjectCategoryType(int projectCategoryId, int projectTypeId);
        Task<List<ProjectCategory>> GetAllCategoriesByType(int projectType);
        Task<List<ProjectType>> GetAllTypesByCategory(int projectCategory);
        Task<ContentCategory> GetCategoryById(int id);
        Task<bool> DeleteProjectCategoryType(int projectCategoryId, int projectTypeId);
    }
}
