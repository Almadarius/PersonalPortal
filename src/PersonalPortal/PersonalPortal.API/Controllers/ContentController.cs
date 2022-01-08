using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;

namespace PersonalPortal.API.Controllers
{
    public class ContentController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="medium"></param>
        /// <returns></returns>
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

        [HttpGet]
        [Route("Medium/Get/{name}")]
        public IActionResult GetMedium(string filter)
        { 
            var result = new ContentMedium();

            return Ok(result);
        }

        [HttpPost]
        [Route("Medium/Update/{id}")]
        public IActionResult UpdateMedium([FromBody] ContentMedium medium)
        {
            var result = medium;

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
