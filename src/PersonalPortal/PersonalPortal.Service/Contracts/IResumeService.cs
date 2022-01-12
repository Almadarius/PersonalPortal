using PersonalPortal.Models.Models;

namespace PersonalPortal.Service.Contracts
{
    public interface IResumeService
    {
        Task<bool> RegisterResume(Resume resume);
        Task<List<Resume>> GetAllResumes();
        Task<List<Resume>> GetResumeByName(string filter);
        Task<Resume> GetResumeById(int id);
        Task<bool> UpdateResume(Resume resume);
        Task<bool> DeleteResume(int id);
    }
}
