using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IContactInfoTypeService
    {
        Task<bool> RegisterContactInfoType(ContactInfoType contactInfoType);
        Task<List<ContactInfoType>> GetAllContactInfoType();
        Task<List<ContactInfoType>> GetContactInfoTypeByName(string filter);
        Task<ContactInfoType> GetContactInfoTypeById(int id);
        Task<bool> UpdateContactInfoType(ContactInfoType contactInfoType);
        Task<bool> DeleteContactInfoType(int id);
    }
}
