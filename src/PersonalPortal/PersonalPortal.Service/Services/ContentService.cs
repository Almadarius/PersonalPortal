using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentService :
        IContentMediumService,
        IContentCategoryService,
        IContentIdeaCategoryMediumService,
        IContentIdeaService
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

        public async Task<bool> DeleteContentIdea(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMedium(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAllIdeas()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAllIdeasCategoriesMedia()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAllMediums()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetCategoryByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetIdeaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetIdeaByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetInfoByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetInfoByIdeaId(int ideaId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetInfoByMediumId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetMediumById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetMediumByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> RegisterContentCategory(ContentCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> RegisterContentIdea(ContentIdea idea)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> RegisterContentMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateCategory(ContentCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateContentIdea(ContentIdea idea)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateMedium(ContentMedium medium)
        {
            throw new NotImplementedException();
        }
    }
}
