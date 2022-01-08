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
        public async Task<IActionResult> RegisterContentMedium([FromBody] ContentMedium medium)
        {
            var result = 0;

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Medium/GetAll")]
        public async Task<IActionResult> GetAllMediums()
        { 
            var result = new List<ContentMedium>();

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Medium/Get/{name}")]
        public async Task<IActionResult> GetMedium(string filter)
        { 
            var result = new ContentMedium();

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medium"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Medium/Update/{id}")]
        public async Task<IActionResult> UpdateMedium([FromBody] ContentMedium medium)
        {
            var result = medium;

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Medium/Delete/{id}")]
        public async Task<IActionResult> DeleteMedium(int id)
        {
            var result = false;

            return Ok(result);
        }
    }
}
