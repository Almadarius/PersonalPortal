using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResourceTypeService : IResourceTypeService
    {
        public Task<bool> DeleteResourceType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceType>> GetAllResourceTypes()
        {
            throw new NotImplementedException();
        }

        public Task<ResourceType> GetResourceTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResourceType>> GetResourceTypeByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResourceType(ResourceType resourceType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateResourceType(ResourceType resourceType)
        {
            throw new NotImplementedException();
        }
    }
}
