using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        public Task<bool> DeleteProjectCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectCategory>> GetAllProjectCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProjectCategory> GetProjectCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectCategory>> GetProjectCategoryByName(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterProjectCategory(ProjectCategory projectCategory)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectCategory(ProjectCategory projectCategory)
        {
            throw new NotImplementedException();
        }
    }
}
