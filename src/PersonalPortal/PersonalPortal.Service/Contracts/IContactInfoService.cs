using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContactInfoService
    {
        Task<bool> RegisterContactInfo(ContactInfo contactInfo);
        Task<List<ContactInfo>> GetAllContactInfoRecords();
        Task<List<ContactInfo>> GetContactInfoByName(string filter);
        Task<ContactInfo> GetContactInfoById(int id);
        Task<bool> UpdateContactInfo(ContactInfo contactInfo);
        Task<bool> DeleteContactInfo(int id);
    }
}
