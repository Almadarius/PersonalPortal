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

        #region ContentCategory
        [HttpPut]
        [Route("Category/Create")]
        public async Task<IActionResult> RegisterContentCategory([FromBody] ContentCategory category)
        {            
            if (category == null)
                return BadRequest("A ContentCategory object is required");
                
            var result = await _contentCategoryService.RegisterContentCategory(category);

            return Ok(result);
        }

        [HttpGet]
        [Route("Category/GetAll")]        
        public async Task<IActionResult> GetAllContentCategories()
        { 
            var result = await _contentCategoryService.GetAllContentCategories();

            if (result == null || result.Count == 0)
                return NotFound("There are no categories");

            return Ok(result);
        }

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
        #endregion

        #region ContentMedium

        [HttpPut]
        [Route("Medium/Register")]
        public async Task<IActionResult> RegisterContentMedium([FromBody] ContentMedium contentMedium)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _contentMediumService.RegisterContentMedium(contentMedium);

            if (result == false)
                return StatusCode(500, "Was not able to register the medium");

            return Ok(result);
        }

        [HttpGet]
        [Route("Medium/GetAll")]
        public async Task<IActionResult> GetAllContentMedia()
        { 
            var result = await _contentMediumService.GetAllContentMediums();

            if (result == null || result.Count == 0)
                return NotFound("No Media was found");

            return Ok(result);
        }

        [HttpGet]
        [Route("Medium/Get/{id}")]
        public async Task<IActionResult> GetContentMediumById(int id)
        {
            if (id < 1)
                return NotFound("The value of Id should be greater than 0");

            var result = await _contentMediumService.GetContentMediumById(id);

            if (result == null)
                return StatusCode(500, "Was not able to obtain the Medium");

            return Ok(result);

        }

        [HttpGet]
        [Route("Medium/Get/{filter}")]
        public async Task<IActionResult> GetContentMediumByName(string filter)
        {
            if (filter == null)
                return BadRequest("Filter cannot be null");

            var result = await _contentMediumService.GetContentMediumByName(filter);

            if (result == null)
                return StatusCode(500, "Was not able to obtain the Medium");

            return Ok(result);
        }

        [HttpPost]
        [Route("Medium/Update")]
        public async Task<IActionResult> UpdateContentMedium([FromBody] ContentMedium contentMedium)
        {
            if (contentMedium == null)
                return BadRequest("Medium cannot be null");

            var result = await _contentMediumService.UpdateContentMedium(contentMedium);

            if (result == false)
                return StatusCode(500, "Was not able to update that Medium");

            return Ok(result);
        }

        [HttpDelete]
        [Route("Medium/Delete/{id}")]
        public async Task<IActionResult> DeleteContentMedium(int id)
        {
            if (id < 1)
                return BadRequest("The value of Id must be greater than 0");

            var result = await _contentMediumService.DeleteContentMedium(id);

            if (result == false)
                return StatusCode(500, "Was not able to delete the Medium");

            return Ok(result);
        }

        #endregion

        #region ContentIdea



        #endregion

        #region ContentIdeaCategoryMedium



        #endregion

    }
}
