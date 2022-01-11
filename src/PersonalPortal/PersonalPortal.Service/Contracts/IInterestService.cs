using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IInterestService
    {
        Task<bool> RegisterInterest(Interest interest);
        Task<List<Interest>> GetAllInterests();
        Task<List<Interest>> GetInterestByName(string filter);
        Task<Interest> GetInterestById(int id);
        Task<bool> UpdateInterest(Interest interest);
        Task<bool> DeleteInterest(int id);
    }
}
