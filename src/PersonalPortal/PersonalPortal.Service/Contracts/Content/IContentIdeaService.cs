using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaService
    {        
        Task<bool> RegisterContentIdea(ContentIdea idea);
        Task<List<ContentIdea>> GetAllContentIdeas();
        Task<List<ContentIdea>> GetContentIdeaByName(string filter);
        Task<List<ContentIdea>> GetContentIdeaById(int id);
        Task<bool> UpdateContentIdea(ContentIdea idea);
        Task<bool> DeleteContentIdea(int id);        
    }
}
