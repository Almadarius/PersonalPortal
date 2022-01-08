using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Job
    {
        public Job()
        {
            JobBulletPoints = new HashSet<JobBulletPoint>();
            Resumes = new HashSet<Resume>();
        }

        public int JobId { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string JobTitle { get; set; } = null!;

        public virtual ICollection<JobBulletPoint> JobBulletPoints { get; set; }

        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
