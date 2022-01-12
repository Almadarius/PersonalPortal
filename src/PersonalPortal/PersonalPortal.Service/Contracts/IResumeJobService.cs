using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeJobService
    {
        Task<bool> RegisterResumeJob(int resumeId, int jobId);
        Task<List<Job>> GetAllJobsByResume(int resumeId);                        
        Task<bool> DeleteResumeJob(int resumeId, int jobId);
    }
}
