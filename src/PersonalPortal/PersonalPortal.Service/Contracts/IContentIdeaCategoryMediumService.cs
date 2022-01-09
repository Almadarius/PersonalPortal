using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaCategoryMediumService
    {
        Task<bool> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
        Task<List<ContentIdeaCategoryMedium>> GetAllIdeasCategoriesMedia();
        Task<List<ContentIdeaCategoryMedium>> GetInfoByIdeaId(int ideaId);
        Task<List<ContentIdeaCategoryMedium>> GetInfoByCategoryId(int categoryId);
        Task<List<ContentIdeaCategoryMedium>> GetInfoByMediumId(int categoryId);
        Task<bool> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea);
        Task<bool> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
    }
}
