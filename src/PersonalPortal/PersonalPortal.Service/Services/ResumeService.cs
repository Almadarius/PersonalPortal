using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ResumeService : IResumeService
    {
        public Task<bool> DeleteResume(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Resume>> GetAllResumes()
        {
            throw new NotImplementedException();
        }

        public Task<Resume> GetResumeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Resume>> GetResumeByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterResume(Resume resume)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateResume(Resume resume)
        {
            throw new NotImplementedException();
        }
    }
}
