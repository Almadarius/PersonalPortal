using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResourceCategoryService
    {
        Task<bool> RegisterResourceCategory(ResourceCategory resourceCategory);
        Task<List<ResourceCategory>> GetAllResourceCategories();
        Task<List<ResourceCategory>> GetResourceCategoryByName(string filter);
        Task<ResourceCategory> GetResourceCategoryById(int id);
        Task<bool> UpdateResourceCategory(ResourceCategory resourceCategory);
        Task<bool> DeleteResourceCategory(int id);
    }
}
