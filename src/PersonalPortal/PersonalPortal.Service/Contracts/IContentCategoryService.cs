using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentCategoryService
    {
        Task<IActionResult> RegisterContentCategory(ContentCategory category);
        Task<IActionResult> GetAllCategories();
        Task<IActionResult> GetCategoryByName(string filter);
        Task<IActionResult> GetCategoryById(int id);
        Task<IActionResult> UpdateCategory(ContentCategory category);
        Task<IActionResult> DeleteCategory(int id);
    }
}
