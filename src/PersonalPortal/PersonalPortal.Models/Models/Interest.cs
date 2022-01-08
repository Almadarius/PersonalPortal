using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Interest
    {
        public Interest()
        {
            Resumes = new HashSet<Resume>();
        }

        public int InterestId { get; set; }
        public string InterestName { get; set; } = null!;

        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
