using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeEducationInfoService
    {
        Task<bool> RegisterResumeEducationInfo(int resumeId, int educationInfo);
        Task<List<EducationInfo>> GetAllEducationInfoRecordsByResume(int resumeId);
        Task<bool> DeleteResumeEducationInfo(int resumeId, int educationInfo);
    }
}
