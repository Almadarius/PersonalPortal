using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResourceService
    {
        Task<bool> RegisterResource(Resource staticResource);
        Task<List<Resource>> GetAllResources();
        Task<List<Resource>> GetResourceByName(string filter);
        Task<Resource> GetResourceById(int id);
        Task<bool> UpdateResource(Resource staticResource);
        Task<bool> DeleteResource(int id);
    }
}
