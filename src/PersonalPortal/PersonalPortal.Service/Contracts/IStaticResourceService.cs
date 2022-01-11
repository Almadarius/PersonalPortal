using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IStaticResourceService
    {
        Task<bool> RegisterStaticResource(StaticResource staticResource);
        Task<List<StaticResource>> GetAllStaticResources();
        Task<List<StaticResource>> GetStaticResourceByName(string filter);
        Task<StaticResource> GetStaticResourceById(int id);
        Task<bool> UpdateStaticResource(StaticResource staticResource);
        Task<bool> DeleteStaticResource(int id);
    }
}
