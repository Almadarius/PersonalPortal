using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class PlatformService : IPlatformService
    {
        public Task<bool> DeletePlatform(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Platform>> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetPlatformById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Platform>> GetSPlatformByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterPlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePlatform(StaticResource staticResource)
        {
            throw new NotImplementedException();
        }
    }
}
