using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContactInfoType
    {
        public ContactInfoType()
        {
            ContactInfos = new HashSet<ContactInfo>();
        }

        public int ContactInfoTypeId { get; set; }
        public string ContactInfoName { get; set; } = null!;
        public string? ContactInfoDescription { get; set; }

        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
