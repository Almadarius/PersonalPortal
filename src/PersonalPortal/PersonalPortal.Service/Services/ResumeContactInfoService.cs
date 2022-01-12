using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeContactInfoService : IResumeContactInfoService
    {
        public Task<bool> DeleteContactInfo(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfo>> GetAllContactInfoRecordsByResume(int resumeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResumeContactInfo(int resumeId, int contactInfoId)
        {
            throw new NotImplementedException();
        }
    }
}
