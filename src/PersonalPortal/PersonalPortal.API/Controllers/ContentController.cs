using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.API.Controllers
{
    public class ContentController : Controller
    {
        [HttpPut]
        [Route("Medium/Create")]
        public IActionResult RegisterContentMedium([FromBody] ContentMedium medium)
        {
            var result = 0;

            return Ok(result);
        }

        [HttpGet]
        [Route("Medium/GetAll")]
        public IActionResult GetAllMediums()
        { 
            var result = new List<ContentMedium>();

            return Ok(result);
        }

        [HttpDelete]
        [Route("Medium/Delete/{id}")]
        public IActionResult DeleteMedium(int id)
        {
            var result = false;

            return Ok(result);
        }
    }
}
