using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeInterestService
    {
        Task<bool> RegisterResumeInterest(int resumeId, int interestId);
        Task<List<Interest>> GetAllInterestsByResume(int resumeId);        
        Task<bool> DeleteResumeInterest(int resumeId);
    }
}
