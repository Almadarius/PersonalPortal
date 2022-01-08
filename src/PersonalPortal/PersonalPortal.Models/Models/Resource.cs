using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Resource
    {
        public Resource()
        {
            Resources = new HashSet<ResourceCategory>();
        }

        public int ResourceId { get; set; }
        public int PlatformId { get; set; }
        public string ResourceName { get; set; } = null!;
        public string ResouceAltText { get; set; } = null!;
        public string ResourceUrl { get; set; } = null!;
        public string? ResourceDescription { get; set; }
        public bool IsOpen { get; set; }
        public bool IsRelativeUrl { get; set; }

        public virtual Platform Platform { get; set; } = null!;

        public virtual ICollection<ResourceCategory> Resources { get; set; }
    }
}
