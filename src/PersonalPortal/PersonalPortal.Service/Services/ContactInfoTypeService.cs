using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ContactInfoTypeService : IContactInfoTypeService
    {
        public Task<bool> DeleteContactInfoType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfoType>> GetAllContactInfoType()
        {
            throw new NotImplementedException();
        }

        public Task<ContactInfoType> GetContactInfoTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactInfoType>> GetContactInfoTypeByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterContactInfoType(ContactInfoType contactInfoType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContactInfoType(ContactInfoType contactInfoType)
        {
            throw new NotImplementedException();
        }
    }
}
