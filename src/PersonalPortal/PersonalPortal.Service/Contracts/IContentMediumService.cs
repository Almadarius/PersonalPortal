using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentMediumService
    {        
        Task<bool> RegisterContentMedium(ContentMedium medium);
        Task<List<ContentMedium>> GetAllMediums();
        Task<List<ContentMedium>> GetMediumByName(string filter);
        Task<List<ContentMedium>> GetMediumById(int id);
        Task<bool> UpdateMedium(ContentMedium medium);
        Task<bool> DeleteMedium(int id);
    }
}
