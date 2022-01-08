using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentIdeaService
    {        
        Task<IActionResult> RegisterContentIdea(ContentIdea idea);
        Task<IActionResult> GetAllIdeas();
        Task<IActionResult> GetIdeaByName(string filter);
        Task<IActionResult> GetIdeaById(int id);
        Task<IActionResult> UpdateContentIdea(ContentIdea idea);
        Task<IActionResult> DeleteContentIdea(int id);        
    }
}
