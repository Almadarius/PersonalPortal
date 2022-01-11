using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResourceTypeService
    {
        Task<bool> RegisterResourceType(ResourceType resourceType);
        Task<List<ResourceType>> GetAllResourceTypes();
        Task<List<ResourceType>> GetResourceTypeByName(string filter);
        Task<ResourceType> GetResourceTypeById(int id);
        Task<bool> UpdateResourceType(ResourceType resourceType);
        Task<bool> DeleteResourceType(int id);
    }
}
