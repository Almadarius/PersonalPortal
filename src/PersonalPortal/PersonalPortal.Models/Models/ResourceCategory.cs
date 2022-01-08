using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ResourceCategory
    {
        public ResourceCategory()
        {
            Resources = new HashSet<Resource>();
        }

        public int ResourceCategoryId { get; set; }
        public int ResourceTypeId { get; set; }
        public string ResourceCategoryName { get; set; } = null!;
        public string? ResourceCategoryDescription { get; set; }

        public virtual ResourceType ResourceType { get; set; } = null!;

        public virtual ICollection<Resource> Resources { get; set; }
    }
}
