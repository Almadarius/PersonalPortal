using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeSkillService : IResumeSkillService
    {
        public Task<bool> DeleteResumeSkill(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetAllSkillsByResume(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResumeSkill(int resumeId, int skillId)
        {
            throw new NotImplementedException();
        }
    }
}
