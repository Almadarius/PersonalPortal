using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class JobService : IJobService
    {
        public Task<bool> DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetAllJobs()
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetJobById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetJobByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
