using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class EducationInfo
    {
        public EducationInfo()
        {
            Resumes = new HashSet<Resume>();
        }

        public int EducationInfoId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string DegreeObtained { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
