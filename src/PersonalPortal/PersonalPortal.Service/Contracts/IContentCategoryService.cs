using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentCategoryService
    {
        Task<bool> RegisterContentCategory(ContentCategory category);
        Task<List<ContentCategory>> GetAllCategories();
        Task<List<ContentCategory>> GetCategoryByName(string filter);
        Task<ContentCategory> GetCategoryById(int id);
        Task<bool> UpdateCategory(ContentCategory category);
        Task<bool> DeleteCategory(int id);
    }
}
