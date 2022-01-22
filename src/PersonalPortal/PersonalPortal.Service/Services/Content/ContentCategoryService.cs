using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentCategoryService :        
        IContentCategoryService
    {
        PersonalPortalContext context = new PersonalPortalContext();

        public bool DeleteContentCategory(ContentCategory contentCategory)
        { 
            context.ContentCategories.Remove(contentCategory);
            var result = context.SaveChanges();

            return result == 1;
        }

        public async Task<bool> DeleteContentCategory(int id)
        {
            var result = false;
            var category = new ContentCategory();

            try
            {
                category = context.ContentCategories.SingleOrDefault(cc => cc.ContentCategoryId == id);
                var delete = Task.Run(() => DeleteContentCategory(category));
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

        public async Task<List<ContentCategory>> GetAllContentCategories()
        {
            return await Task.Run(() => context.ContentCategories.ToList());
        }

        public async Task<ContentCategory> GetContentCategoryById(int id)
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

        public async Task<List<ContentCategory>> GetContentCategoryByName(string filter)
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

        public async Task<bool> RegisterContentCategory(ContentCategory contentCategory)
        {            
            var registered = 0;

            try
            {
                context.ContentCategories.Add(contentCategory);
                registered = await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //TODO: logging
                return false;
            }

            return registered == 1;
        }

        public bool UpdateContentCategory(ContentCategory originalContentCategory, ContentCategory newContentCategory)
        { 
            originalContentCategory.ContentCategoryName = newContentCategory.ContentCategoryName;
            originalContentCategory.ContentCategoryDescription = newContentCategory.ContentCategoryDescription;
            var updated = context.SaveChanges();

            return updated == 1;
        }

        public async Task<bool> UpdateContentCategory(ContentCategory contentCategory)
        {
            var result = false;            

            try
            {
                var cat = context.ContentCategories.SingleOrDefault(cc => cc.ContentCategoryId == contentCategory.ContentCategoryId);
                var update = Task.Run(() => UpdateContentCategory(cat, contentCategory));
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
