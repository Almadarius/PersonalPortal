using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeContactInfoService
    {
        Task<bool> RegisterResumeContactInfo(int resumeId, int contactInfoId);
        Task<List<ContactInfo>> GetAllContactInfoRecordsByResume(int resumeId);
        Task<bool> DeleteContactInfo(int resumeId);
    }
}
