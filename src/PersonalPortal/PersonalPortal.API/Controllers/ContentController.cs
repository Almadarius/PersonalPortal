using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly IContentCategoryService _contentCategoryService;

        public ContentController(IContentCategoryService contentCategoryService)
        {
            _contentCategoryService = contentCategoryService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Category/Create")]
        public async Task<IActionResult> RegisterContentCategory([FromBody] ContentCategory category)
        {            
            if (category == null)
            {
                return BadRequest("A ContentCategory object is required");
            }
                
            var result = await _contentCategoryService.RegisterContentCategory(category);

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Category/GetAll")]
        public async Task<IActionResult> GetAllContentCategories()
        { 
            var result = new List<ContentCategory>();

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Category/Get/{id}")]
        public async Task<IActionResult> GetContentCategoryById(int id)
        { 
            var result = new ContentCategory();

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Category/Get/{name}")]
        public async Task<IActionResult> GetContentCategoryByName(string filter)
        { 
            var result = new List<ContentCategory>();

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Category/Update/{id}")]
        public async Task<IActionResult> UpdateContentCategory([FromBody] ContentCategory category)
        {
            var result = category;

            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Category/Delete/{id}")]
        public async Task<IActionResult> DeleteContentCategory(int id)
        {
            var result = false;

            return Ok(result);
        }
    }
}
