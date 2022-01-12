using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeJobService : IResumeJobService
    {
        public Task<bool> DeleteResumeJob(int resumeId, int jobId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetAllJobsByResume(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResumeJob(int resumeId, int jobId)
        {
            throw new NotImplementedException();
        }
    }
}
