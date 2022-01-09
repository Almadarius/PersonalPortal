using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentMediumService : IContentMediumService
    {
        public Task<bool> DeleteMedium(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentMedium>> GetAllMediums()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentMedium>> GetMediumById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentMedium>> GetMediumByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContentMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }
    }
}
