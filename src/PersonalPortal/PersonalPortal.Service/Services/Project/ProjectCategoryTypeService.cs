using PersonalPortal.Models.Models;
using PersonalPortal.Service.Contracts;

namespace PersonalPortal.Service.Services
{
    public class ProjectCategoryTypeService : IProjectCategoryTypeService
    {
        public Task<bool> DeleteProjectCategoryType(int projectCategoryId, int projectTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectCategory>> GetAllCategoriesByType(int projectType)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectType>> GetAllTypesByCategory(int projectCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ContentCategory> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterProjectCategoryType(int projectCategoryId, int projectTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
