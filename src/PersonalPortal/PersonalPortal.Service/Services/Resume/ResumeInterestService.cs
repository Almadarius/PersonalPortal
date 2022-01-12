using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeInterestService : IResumeInterestService
    {
        public Task<bool> DeleteResumeInterest(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Interest>> GetAllInterestsByResume(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResumeInterest(int resumeId, int interestId)
        {
            throw new NotImplementedException();
        }
    }
}
