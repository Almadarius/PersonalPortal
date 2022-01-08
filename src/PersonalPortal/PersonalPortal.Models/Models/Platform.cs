using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Platform
    {
        public Platform()
        {
            Resources = new HashSet<Resource>();
        }

        public int PlatformId { get; set; }
        public string PlatformBaseUrl { get; set; } = null!;
        public string PlatformName { get; set; } = null!;
        public string? PlatformDescription { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}
