using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            ProjectCategories = new HashSet<ProjectCategory>();
        }

        public int ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; } = null!;
        public string? ProjectTypeDescription { get; set; }

        public virtual ICollection<ProjectCategory> ProjectCategories { get; set; }
    }
}
