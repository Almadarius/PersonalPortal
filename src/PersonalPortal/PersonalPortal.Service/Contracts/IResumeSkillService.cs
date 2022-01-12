using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeSkillService
    {
        Task<bool> RegisterResumeSkill(int resumeId, int skillId);
        Task<List<Skill>> GetAllSkillsByResume(int resumeId);        
        Task<bool> DeleteResumeSkill(int resumeId);
    }
}
