using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IPlatformService
    {
        Task<bool> RegisterPlatform(Platform platform);
        Task<List<Platform>> GetAllPlatforms();
        Task<List<Platform>> GetSPlatformByName(string filter);
        Task<Platform> GetPlatformById(int id);
        Task<bool> UpdatePlatform(StaticResource staticResource);
        Task<bool> DeletePlatform(int id);
    }
}
