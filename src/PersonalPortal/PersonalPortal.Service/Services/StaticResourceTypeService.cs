using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class StaticResourceTypeService : IStaticResourceTypeService
    {
        public Task<bool> DeleteStaticResourceType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaticResourceType>> GetAllStaticResourceTypes()
        {
            throw new NotImplementedException();
        }

        public Task<StaticResourceType> GetStaticResourceTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StaticResourceType>> GetStaticResourceTypeByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterStaticResourceType(StaticResourceType staticResourceType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStaticResourceType(StaticResourceType staticResourceType)
        {
            throw new NotImplementedException();
        }
    }
}
