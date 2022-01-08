using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Resume
    {
        public Resume()
        {
            EducationInfos = new HashSet<EducationInfo>();
            Interests = new HashSet<Interest>();
            Jobs = new HashSet<Job>();
            Skills = new HashSet<Skill>();
        }

        public int ResumeId { get; set; }
        public string ResumeName { get; set; } = null!;
        public string? ResumeDescription { get; set; }
        public bool IsLatestVersion { get; set; }

        public virtual ICollection<EducationInfo> EducationInfos { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
