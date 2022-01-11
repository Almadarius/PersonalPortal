using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResourceService
    {
        Task<bool> RegisterResource(Resource resource);
        Task<List<Resource>> GetAllResources();
        Task<List<Resource>> GetResourceByName(string filter);
        Task<Resource> GetResourceById(int id);
        Task<bool> UpdateResource(Resource resource);
        Task<bool> DeleteResource(int id);
    }
}
