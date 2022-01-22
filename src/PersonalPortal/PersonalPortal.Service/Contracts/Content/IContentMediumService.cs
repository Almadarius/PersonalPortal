using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentMediumService
    {        
        Task<bool> RegisterContentMedium(ContentMedium medium);
        Task<List<ContentMedium>> GetAllContentMediums();
        Task<List<ContentMedium>> GetContentMediumByName(string filter);
        Task<ContentMedium> GetContentMediumById(int id);
        Task<bool> UpdateContentMedium(ContentMedium medium);
        Task<bool> DeleteContentMedium(int id);
    }
}
