using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class JobBulletPointService : IJobBulletPointService
    {
        public Task<bool> DeleteJobBulletPoint(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobBulletPoint>> GetAllJobBulletPoints()
        {
            throw new NotImplementedException();
        }

        public Task<List<JobBulletPoint>> GetJobBulletPointByDescription(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<JobBulletPoint> GetJobBulletPointById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterJobBulletPoint(JobBulletPoint jobBulletPoint)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateJobBulletPoint(JobBulletPoint jobBulletPoint)
        {
            throw new NotImplementedException();
        }
    }
}
