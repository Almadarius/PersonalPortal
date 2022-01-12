using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IJobBulletPointService
    {
        Task<bool> RegisterJobBulletPoint(JobBulletPoint jobBulletPoint);
        Task<List<JobBulletPoint>> GetAllJobBulletPoints();
        Task<List<JobBulletPoint>> GetJobBulletPointByDescription(string filter);
        Task<JobBulletPoint> GetJobBulletPointById(int id);
        Task<bool> UpdateJobBulletPoint(JobBulletPoint jobBulletPoint);
        Task<bool> DeleteJobBulletPoint(int id);
    }
}
