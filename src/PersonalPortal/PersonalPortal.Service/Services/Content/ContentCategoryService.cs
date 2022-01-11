using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentCategoryService :        
        IContentCategoryService
    {
        PersonalPortalContext context = new PersonalPortalContext();

        public bool DeleteCategory(ContentCategory category)
        { 
            context.ContentCategories.Remove(category);
            var result = context.SaveChanges();

            return result == 1;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var result = false;
            var category = new ContentCategory();

            try
            {
                category = context.ContentCategories.SingleOrDefault(cc => cc.ContentCategoryId == id);
                var delete = Task.Run(() => DeleteCategory(category));
                result = await delete;
            }
            catch (InvalidOperationException ex)
            {
                //TODO: logging
                return result;
            }
            catch  (Exception ex)
            { 
                //TODO: logging
                return result;
            }

            return result;
        }

        public async Task<List<ContentCategory>> GetAllCategories()
        {
            return await Task.Run(() => context.ContentCategories.ToList());
        }

        public async Task<ContentCategory> GetCategoryById(int id)
        {
            var category = new ContentCategory();

            try
            {
                category = await Task.Run(() => context.ContentCategories.SingleOrDefault(cc => cc.ContentCategoryId == id));
            }
            catch (InvalidOperationException ex)
            {
                //TODO: logging
                return category;
            }
            catch (Exception ex)
            {
                //TODO: logging
                return category;
            }

            return category;
        }

        public async Task<List<ContentCategory>> GetCategoryByName(string filter)
        {
            var categories = new List<ContentCategory>();

            try
            {
                categories = await Task.Run(() => context.ContentCategories.Where(cc => cc.ContentCategoryName.Contains(filter)).ToList());
            }
            catch (Exception ex)
            {
                //TODO: logging
                return categories;
            }

            return categories;
        }

        public async Task<bool> RegisterContentCategory(ContentCategory category)
        {
            var result = false;
            var registered = 0;

            try
            {
                context.ContentCategories.Add(category);
                registered = await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //TODO: logging
                return false;
            }

            return registered == 1;

        }

        public bool UpdateCategory(ContentCategory originalCategory, ContentCategory newCategory)
        { 
            originalCategory.ContentCategoryName = newCategory.ContentCategoryName;
            originalCategory.ContentCategoryDescription = newCategory.ContentCategoryDescription;
            var updated = context.SaveChanges();

            return updated == 1;
        }

        public async Task<bool> UpdateCategory(ContentCategory category)
        {
            var result = false;
            var updated = 0;

            try
            {
                var cat = context.ContentCategories.SingleOrDefault(cc => cc.ContentCategoryId == category.ContentCategoryId);
                var update = Task.Run(() => UpdateCategory(cat, category));
                result = await update;
            }
            catch (Exception ex)
            {
                //TODO: logging
                return result;
            }

            return result;
        }
    }
}
