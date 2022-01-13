using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResourceCategoryService : IResourceCategoryService
    {
        public Task<bool> DeleteResourceCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceCategory>> GetAllResourceCategories()
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

        public Task<bool> RegisterResourceCategory(ResourceCategory resourceCategory)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateResourceCategory(ResourceCategory resourceCategory)
        {
            throw new NotImplementedException();
        }
    }
}
