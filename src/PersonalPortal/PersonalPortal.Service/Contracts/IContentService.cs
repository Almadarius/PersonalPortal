using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentService
    {
        #region ContentMedium
        Task<IActionResult> RegisterContentMedium(ContentMedium medium);
        Task<IActionResult> GetAllMediums();
        Task<IActionResult> GetMediumByName(string filter);
        Task<IActionResult> GetMediumById(int id);
        Task<IActionResult> UpdateMedium(ContentMedium medium);
        Task<IActionResult> DeleteMedium(int id);
        #endregion

        #region ContentCategory
        Task<IActionResult> RegisterContentCategory(ContentCategory category);
        Task<IActionResult> GetAllCategories();
        Task<IActionResult> GetCategoryByName(string filter);
        Task<IActionResult> GetCategoryById(int id);
        Task<IActionResult> UpdateCategory(ContentCategory category);
        Task<IActionResult> DeleteCategory(int id);
        #endregion

        #region ContentIdea
        Task<IActionResult> RegisterContentIdea(ContentIdea idea);
        Task<IActionResult> GetAllIdeas();
        Task<IActionResult> GetIdeaByName(string filter);
        Task<IActionResult> GetIdeaById(int id);
        Task<IActionResult> UpdateContentIdea(ContentIdea idea);
        Task<IActionResult> DeleteContentIdea(int id);
        #endregion

        #region ContentIdeaCategoryMedium
        Task<IActionResult> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
        Task<IActionResult> GetAllIdeasCategoriesMedia();
        Task<IActionResult> GetInfoByIdeaId(int ideaId);
        Task<IActionResult> GetInfoByCategoryId(int categoryId);
        Task<IActionResult> GetInfoByMediumId(int categoryId);
        Task<IActionResult> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea);
        Task<IActionResult> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
        #endregion
    }
}
