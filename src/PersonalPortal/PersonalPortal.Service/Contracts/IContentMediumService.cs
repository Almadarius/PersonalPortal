using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentMediumService
    {        
        Task<IActionResult> RegisterContentMedium(ContentMedium medium);
        Task<IActionResult> GetAllMediums();
        Task<IActionResult> GetMediumByName(string filter);
        Task<IActionResult> GetMediumById(int id);
        Task<IActionResult> UpdateMedium(ContentMedium medium);
        Task<bool> DeleteMedium(int id);
    }
}
