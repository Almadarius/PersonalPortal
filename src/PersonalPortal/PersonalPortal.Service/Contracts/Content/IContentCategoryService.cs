using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentCategoryService
    {
        Task<bool> RegisterContentCategory(ContentCategory contentCategory);
        Task<List<ContentCategory>> GetAllContentCategories();
        Task<List<ContentCategory>> GetContentCategoryByName(string filter);
        Task<ContentCategory> GetContentCategoryById(int id);
        Task<bool> UpdateContentCategory(ContentCategory contentCategory);
        Task<bool> DeleteContentCategory(int id);
    }
}
