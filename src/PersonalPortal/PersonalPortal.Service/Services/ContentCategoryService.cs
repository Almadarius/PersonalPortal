using Microsoft.AspNetCore.Mvc;
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
                //logging
                return result;
            }
            catch  (Exception ex)
            { 
                //logging
                return result;
            }

            return result;
        }

        public Task<List<ContentCategory>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ContentCategory> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentCategory>> GetCategoryByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContentCategory(ContentCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategory(ContentCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
