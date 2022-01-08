using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContentService
    {
        Task<IActionResult> RegisterContentMedium(ContentMedium medium);
        Task<IActionResult> GetAllMediums();
        Task<IActionResult> GetMedium(string filter);
        Task<IActionResult> UpdateMedium(ContentMedium medium);
        Task<IActionResult> DeleteMedium(int id);
        Task<IActionResult> ClearMediums();
    }
}
