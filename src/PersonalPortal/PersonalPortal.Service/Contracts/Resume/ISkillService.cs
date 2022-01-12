using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface ISkillService
    {
        Task<bool> RegisterSkill(Skill skill);
        Task<List<Skill>> GetAllSkills();
        Task<List<Skill>> GetSkillByName(string filter);
        Task<Skill> GetSkillById(int id);
        Task<bool> UpdateSkill(Skill skill);
        Task<bool> DeleteSkill(int id);
    }
}
