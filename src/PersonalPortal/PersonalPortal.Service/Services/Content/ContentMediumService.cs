using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentMediumService : IContentMediumService
    {
        public Task<bool> DeleteContentMedium(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentMedium>> GetAllContentMediums()
        {
            throw new NotImplementedException();
        }

        public Task<ContentMedium> GetContentMediumById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentMedium>> GetContentMediumByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContentMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContentMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }
    }
}
