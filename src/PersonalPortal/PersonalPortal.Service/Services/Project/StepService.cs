using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class StepService : IStepService
    {
        public Task<bool> DeleteStep(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Step>> GetAllSteps()
        {
            throw new NotImplementedException();
        }

        public Task<Step> GetStepById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Step>> GetStepByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterStep(Step step)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStep(Step step)
        {
            throw new NotImplementedException();
        }
    }
}
