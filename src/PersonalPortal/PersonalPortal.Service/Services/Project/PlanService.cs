using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class PlanService : IPlanService
    {
        public Task<bool> DeletePlan(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Plan>> GetAllPlans()
        {
            throw new NotImplementedException();
        }

        public Task<Plan> GetPlanById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Plan>> GetPlanByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterPlan(Plan plan)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePlan(Plan plan)
        {
            throw new NotImplementedException();
        }
    }
}
