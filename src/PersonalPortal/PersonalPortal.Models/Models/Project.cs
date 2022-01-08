using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Project
    {
        public Project()
        {
            Projects = new HashSet<ProjectCategory>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public string ProjectDescription { get; set; } = null!;

        public virtual ICollection<ProjectCategory> Projects { get; set; }
    }
}
