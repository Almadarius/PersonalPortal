using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.API.Controllers
{
    public class ContentController : Controller
    {
        [HttpPut]
        [Route("CreateContentMedium")]
        public IActionResult RegisterContentMedium([FromBody] ContentMedium medium)
        {
            var result = 0;

            return Ok(result);
        }
    }
}
