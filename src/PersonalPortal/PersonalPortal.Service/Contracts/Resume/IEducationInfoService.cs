using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IEducationInfoService
    {
        Task<bool> RegisterEducationInfo(EducationInfo educationInfo);
        Task<List<EducationInfo>> GetAllEducationInfoRecords();
        Task<List<EducationInfo>> GetEducationInfoByDescription(string filter);
        Task<EducationInfo> GetEducationInfoById(int id);
        Task<bool> UpdateEducationInfo(EducationInfo educationInfo);
        Task<bool> DeleteEducationInfo(int id);
    }
}
