using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaCategoryMediumService
    {
        Task<bool> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
        Task<List<ContentIdeaCategoryMedium>> GetAllContentIdeasCategoriesMedia();
        Task<List<ContentIdeaCategoryMedium>> GetInfoByContentIdeaId(int ideaId);
        Task<List<ContentIdeaCategoryMedium>> GetInfoByContentCategoryId(int categoryId);
        Task<List<ContentIdeaCategoryMedium>> GetInfoByContentMediumId(int categoryId);
        Task<bool> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea);
        Task<bool> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
    }
}
