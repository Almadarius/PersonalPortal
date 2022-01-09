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

        public Task<List<ContentIdeaCategoryMedium>> GetAllIdeasCategoriesMedia()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByIdeaId(int ideaId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdeaCategoryMedium>> GetInfoByMediumId(int categoryId)
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
