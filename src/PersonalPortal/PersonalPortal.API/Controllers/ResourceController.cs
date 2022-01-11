using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IStaticResourceService _staticResourceService;
        private readonly IStaticResourceTypeService _staticResourceTypeService;
        private readonly IResourceService _resourceService;
        private readonly IResourceTypeService _resourceTypeService;
        private readonly IResourceCategoryService _resourceCategoryService;
        private readonly IResourceCategoryTypeService _resourceCategoryTypeService;
        private readonly IPlatformService _platformService;

        public ResourceController(IStaticResourceService staticResourceService, IStaticResourceTypeService staticResourceTypeService,
                                  IResourceService resourceService, IResourceTypeService resourceTypeService,
                                  IResourceCategoryService resourceCategoryService, IResourceCategoryTypeService resourceCategoryTypeService,
                                  IPlatformService platformService)
        {
            _staticResourceService = staticResourceService;
            _staticResourceTypeService = staticResourceTypeService;
            _resourceService = resourceService;
            _resourceTypeService = resourceTypeService;
            _resourceCategoryService = resourceCategoryService;
            _resourceCategoryTypeService = resourceCategoryTypeService;
            _platformService = platformService;
        }
    }
}
