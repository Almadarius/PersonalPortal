using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaService
    {        
        Task<bool> RegisterContentIdea(ContentIdea idea);
        Task<List<ContentIdea>> GetAllIdeas();
        Task<List<ContentIdea>> GetIdeaByName(string filter);
        Task<List<ContentIdea>> GetIdeaById(int id);
        Task<bool> UpdateContentIdea(ContentIdea idea);
        Task<bool> DeleteContentIdea(int id);        
    }
}
