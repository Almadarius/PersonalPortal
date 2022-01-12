using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class EducationInfoService : IEducationInfoService
    {
        public Task<bool> DeleteEducationInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EducationInfo>> GetAllEducationInfoRecords()
        {
            throw new NotImplementedException();
        }

        public Task<List<EducationInfo>> GetEducationInfoByDescription(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<EducationInfo> GetEducationInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterEducationInfo(EducationInfo educationInfo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEducationInfo(EducationInfo educationInfo)
        {
            throw new NotImplementedException();
        }
    }
}
