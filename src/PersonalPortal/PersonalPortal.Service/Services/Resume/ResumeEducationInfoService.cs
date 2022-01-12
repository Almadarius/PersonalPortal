using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeEducationInfoService : IResumeEducationInfoService
    {
        public Task<bool> DeleteResumeEducationInfo(int resumeId, int educationInfo)
        {
            throw new NotImplementedException();
        }

        public Task<List<EducationInfo>> GetAllEducationInfoRecordsByResume(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResumeEducationInfo(int resumeId, int educationInfo)
        {
            throw new NotImplementedException();
        }
    }
}
