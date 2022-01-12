using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class SkillService : ISkillService
    {
        public Task<bool> DeleteSkill(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetAllSkills()
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetSkillById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkillByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterSkill(Skill skill)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSkill(Skill skill)
        {
            throw new NotImplementedException();
        }
    }
}
