using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IJobService
    {
        Task<bool> RegisterJob(Job job);
        Task<List<Job>> GetAllJobs();
        Task<List<Job>> GetJobByName(string filter);
        Task<Job> GetJobById(int id);
        Task<bool> UpdateJob(Job job);
        Task<bool> DeleteJob(int id);
    }
}
