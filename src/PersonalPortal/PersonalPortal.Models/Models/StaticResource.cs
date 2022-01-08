using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class StaticResource
    {
        public int StaticResourceId { get; set; }
        public int StaticResourceTypeId { get; set; }
        public string StaticResourceUrl { get; set; } = null!;
        public string StaticResourceName { get; set; } = null!;
        public string? StaticResourceDescription { get; set; }

        public virtual StaticResourceType StaticResourceType { get; set; } = null!;
    }
}
