using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ProjectCategory
    {
        public ProjectCategory()
        {
            Projects = new HashSet<Project>();
        }

        public int ProjectCategoryId { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectCategoryName { get; set; } = null!;
        public string? ProjectCategoryDescription { get; set; }

        public virtual ProjectType ProjectType { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
