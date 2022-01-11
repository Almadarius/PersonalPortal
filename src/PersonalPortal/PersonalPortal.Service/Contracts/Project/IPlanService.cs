using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IPlanService
    {
        Task<bool> RegisterPlan(Plan plan);
        Task<List<Plan>> GetAllPlans();
        Task<List<Plan>> GetPlanByName(string filter);
        Task<Plan> GetPlanById(int id);
        Task<bool> UpdatePlan(Plan plan);
        Task<bool> DeletePlan(int id);
    }
}
