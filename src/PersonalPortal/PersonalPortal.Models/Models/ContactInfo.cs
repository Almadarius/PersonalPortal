using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContactInfo
    {
        public ContactInfo()
        {
            Resumes = new HashSet<Resume>();
        }

        public int ContactInfoId { get; set; }
        public int ContactInfoTypeId { get; set; }
        public string ContactInfoDescription { get; set; } = null!;

        public virtual ContactInfoType ContactInfoType { get; set; } = null!;

        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
