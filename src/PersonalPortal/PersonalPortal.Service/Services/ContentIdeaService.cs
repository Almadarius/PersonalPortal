using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContentIdeaService : IContentIdeaService
    {
        public Task<bool> DeleteContentIdea(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdea>> GetAllIdeas()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdea>> GetIdeaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdea>> GetIdeaByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContentIdea(ContentIdea idea)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContentIdea(ContentIdea idea)
        {
            throw new NotImplementedException();
        }
    }
}
