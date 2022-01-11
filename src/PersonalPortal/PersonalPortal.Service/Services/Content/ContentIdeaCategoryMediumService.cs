using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentIdeaCategoryMediumService : IContentIdeaCategoryMediumService
    {
        public Task<bool> DeleteContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetAllContentIdeasCategoriesMedia()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByContentCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByContentIdeaId(int ideaId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByContentMediumId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContentIdeaCategoryMedium(ContentIdeaCategoryMedium ideaCategoryMedium)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContentIdeaCategoryMedium(ContentIdeaCategoryMedium oldIdea, ContentIdeaCategoryMedium newIdea)
        {
            throw new NotImplementedException();
        }
    }
}
