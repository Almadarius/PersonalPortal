using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IStepService
    {
        Task<bool> RegisterStep(Step step);
        Task<List<Step>> GetAllSteps();
        Task<List<Step>> GetStepByName(string filter);
        Task<Step> GetStepById(int id);
        Task<bool> UpdateStep(Step step);
        Task<bool> DeleteStep(int id);
    }
}
