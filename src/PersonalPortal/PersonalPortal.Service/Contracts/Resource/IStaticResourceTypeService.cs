using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IStaticResourceTypeService
    {
        Task<bool> RegisterStaticResourceType(StaticResourceType staticResourceType);
        Task<List<StaticResourceType>> GetAllStaticResourceTypes();
        Task<List<StaticResourceType>> GetStaticResourceTypeByName(string filter);
        Task<StaticResourceType> GetStaticResourceTypeById(int id);
        Task<bool> UpdateStaticResourceType(StaticResourceType staticResourceType);
        Task<bool> DeleteStaticResourceType(int id);
    }
}
