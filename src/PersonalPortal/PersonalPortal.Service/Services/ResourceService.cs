using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResourceService : IResourceService
    {
        public Task<bool> DeleteResource(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Resource>> GetAllResources()
        {
            throw new NotImplementedException();
        }

        public Task<Resource> GetResourceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Resource>> GetResourceByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResource(Resource resource)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateResource(Resource resource)
        {
            throw new NotImplementedException();
        }
    }
}
