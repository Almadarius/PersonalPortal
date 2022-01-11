using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContactInfoService : IContactInfoService
    {
        public Task<bool> DeleteContactInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfo>> GetAllContactInfoRecords()
        {
            throw new NotImplementedException();
        }

        public Task<ContactInfo> GetContactInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfo>> GetContactInfoByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContactInfo(ContactInfo contactInfo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContactInfo(ContactInfo contactInfo)
        {
            throw new NotImplementedException();
        }
    }
}
