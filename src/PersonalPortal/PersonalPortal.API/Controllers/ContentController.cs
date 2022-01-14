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
        private readonly IContentMediumService _contentMediumService;
        private readonly IContentIdeaService _contentIdeaService;
        private readonly IContentIdeaCategoryMediumService _contentIdeaCategoryMediumService;

        public ContentController(IContentCategoryService contentCategoryService, IContentMediumService contentMediumService,
                                 IContentIdeaService contentIdeaService, IContentIdeaCategoryMediumService contentIdeaCategoryMediumService)
        {
            _contentCategoryService = contentCategoryService;
            _contentMediumService = contentMediumService;
            _contentIdeaService = contentIdeaService;
            _contentIdeaCategoryMediumService = contentIdeaCategoryMediumService;
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
                return BadRequest("A ContentCategory object is required");
                
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
            var result = await _contentCategoryService.GetAllContentCategories();

            if (result == null)
                return NotFound("There are no categories");

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
            if (id < 1)
                return NotFound("Values for id start at 1");


            var result = await _contentCategoryService.GetContentCategoryById(id);

            if (result == null)
                return NotFound("No category with the provided Id was found");


            return Ok(result);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Category/Get/{filter}")]
        public async Task<IActionResult> GetContentCategoryByName(string filter)
        { 
            var result = new List<ContentCategory>();

            if (filter == null)
                return BadRequest("Filter cannot be empty");

            result = await _contentCategoryService.GetContentCategoryByName(filter);

            if (result == null)
                return NotFound("No category matching the filter was found");

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
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _contentCategoryService.UpdateContentCategory(category);

            if (result == false)
                return StatusCode(500, "Update failed");

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
            if (id < 1)
                return NotFound("Values for id start at 1");

            var result = await _contentCategoryService.DeleteContentCategory(id);

            if (result == false)
                return StatusCode(500, "Delete failed");

            return Ok(result);
        }
    }
}
