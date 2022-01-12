using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IPlanService _planService;
        private readonly IStepService _stepService;
        private readonly IProjectService _projectService;
        private readonly IProjectTypeService _projectTypeService;
        private readonly IProjectCategoryService _projectCategoryService;
        private readonly IProjectCategoryTypeService _projectCategoryTypeService;

        public ProjectController(IPlanService planService, IStepService stepService,
                                 IProjectService projectService, IProjectTypeService projectTypeService,
                                 IProjectCategoryService projectCategoryService, IProjectCategoryTypeService projectCategoryTypeService)
        {
            _planService = planService;
            _stepService = stepService;
            _projectService = projectService;
            _projectTypeService = projectTypeService;
            _projectCategoryService = projectCategoryService;
            _projectCategoryTypeService = projectCategoryTypeService;
        }
    }
}
