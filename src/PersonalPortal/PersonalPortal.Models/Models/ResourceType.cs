using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ResourceType
    {
        public ResourceType()
        {
            ResourceCategories = new HashSet<ResourceCategory>();
        }

        public int ResourceTypeId { get; set; }
        public string ResourceTypeName { get; set; } = null!;
        public string? ResourceTypeDescription { get; set; }

        public virtual ICollection<ResourceCategory> ResourceCategories { get; set; }
    }
}
