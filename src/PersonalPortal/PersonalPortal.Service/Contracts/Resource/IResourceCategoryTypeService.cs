using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResourceCategoryTypeService
    {
        Task<bool> RegisterResourceCategoryType(int resourceCategoryId, int resourceTypeId);
        Task<List<ResourceCategory>> GetAllResourceCategoriesByType(int resourceTypeId);
        Task<List<ResourceCategory>> GetResourceCategoryByName(string filter);
        Task<ResourceCategory> GetResourceCategoryById(int id);        
        Task<bool> DeleteResourceCategoryType(int resourceCategoryId, int resourceTypeId);
    }
}
