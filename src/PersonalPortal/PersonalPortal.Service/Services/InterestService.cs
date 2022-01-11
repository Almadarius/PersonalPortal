using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class InterestService : IInterestService
    {
        public Task<bool> DeleteInterest(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Interest>> GetAllInterests()
        {
            throw new NotImplementedException();
        }

        public Task<Interest> GetInterestById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Interest>> GetInterestByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterInterest(Interest interest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateInterest(Interest interest)
        {
            throw new NotImplementedException();
        }
    }
}
