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

        public Task<List<ContentIdea>> GetAllContentIdeas()
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdea>> GetContentIdeaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContentIdea>> GetContentIdeaByName(string filter)
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
