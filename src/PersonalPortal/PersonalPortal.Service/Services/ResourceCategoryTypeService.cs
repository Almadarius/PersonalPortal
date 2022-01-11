using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResourceCategoryTypeService : IResourceCategoryTypeService
    {
        public Task<bool> DeleteResourceCategoryType(int resourceCategoryId, int resourceTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceCategory>> GetAllResourceCategoriesByType(int resourceTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceCategory> GetResourceCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceCategory>> GetResourceCategoryByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResourceCategoryType(int resourceCategoryId, int resourceTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
