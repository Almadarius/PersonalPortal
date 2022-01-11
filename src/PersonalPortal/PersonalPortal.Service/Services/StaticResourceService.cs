using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class StaticResourceService : IStaticResourceService
    {
        public Task<bool> DeleteStaticResource(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaticResource>> GetAllStaticResources()
        {
            throw new NotImplementedException();
        }

        public Task<StaticResource> GetStaticResourceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaticResource>> GetStaticResourceByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterStaticResource(StaticResource staticResource)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStaticResource(StaticResource staticResource)
        {
            throw new NotImplementedException();
        }
    }
}
