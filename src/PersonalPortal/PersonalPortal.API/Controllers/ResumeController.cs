using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IJobBulletPointService _jobBulletPointService;
        private readonly IContactInfoService _contactInfoService;
        private readonly IContactInfoTypeService _contactInfoTypeService;
        private readonly IEducationInfoService _educationInfoService;
        private readonly IInterestService _interestService;
        private readonly ISkillService _skillService;
        private readonly IResumeService _resumeService;
        private readonly IResumeJobService _resumeJobService;
        private readonly IResumeContactInfoService _resumeContactInfoService;
        private readonly IResumeEducationInfoService _resumeEducationInfoService;
        private readonly IResumeInterestService _resumeInterestService;
        private readonly IResumeSkillService _resumeSkillService;

        public ResumeController(IJobService jobService, IJobBulletPointService jobBulletPointService,
                                IContactInfoService contactInfoService, IContactInfoTypeService contactInfoTypeService,
                                IEducationInfoService educationInfoService, IInterestService interestService,
                                ISkillService skillService, IResumeService resumeService, IResumeJobService resumeJobService,
                                IResumeContactInfoService resumeContactInfoService, IResumeEducationInfoService resumeEducationInfoService,
                                IResumeInterestService resumeInterestService, IResumeSkillService resumeSkillService)
        {
            _jobService = jobService;
            _jobBulletPointService = jobBulletPointService;
            _contactInfoService = contactInfoService;
            _contactInfoTypeService = contactInfoTypeService;
            _educationInfoService = educationInfoService;
            _interestService = interestService;
            _skillService = skillService;
            _resumeService = resumeService;
            _resumeJobService = resumeJobService;
            _resumeContactInfoService = resumeContactInfoService;
            _resumeEducationInfoService = resumeEducationInfoService;
            _resumeInterestService = resumeInterestService;
            _resumeSkillService = resumeSkillService;
        }
    }
}
