using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class JobBulletPoint : IJobBulletPoint
    {
        public Task<bool> DeleteJobBulletPoint(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Models.Models.JobBulletPoint>> GetAllJobBulletPoints()
        {
            throw new NotImplementedException();
        }

        public Task<List<Models.Models.JobBulletPoint>> GetJobBulletPointByDescription(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Models.JobBulletPoint> GetJobBulletPointById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterJobBulletPoint(Models.Models.JobBulletPoint jobBulletPoint)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateJobBulletPoint(Models.Models.JobBulletPoint jobBulletPoint)
        {
            throw new NotImplementedException();
        }
    }
}
