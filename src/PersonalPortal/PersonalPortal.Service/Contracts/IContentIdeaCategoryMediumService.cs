using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaCategoryMediumService
    {
        Task<IActionResult> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
        Task<IActionResult> GetAllIdeasCategoriesMedia();
        Task<IActionResult> GetInfoByIdeaId(int ideaId);
        Task<IActionResult> GetInfoByCategoryId(int categoryId);
        Task<IActionResult> GetInfoByMediumId(int categoryId);
        Task<IActionResult> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea);
        Task<IActionResult> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium);
    }
}
