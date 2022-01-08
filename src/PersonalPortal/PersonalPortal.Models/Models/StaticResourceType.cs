using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class StaticResourceType
    {
        public StaticResourceType()
        {
            StaticResources = new HashSet<StaticResource>();
        }

        public int StaticResourceTypeId { get; set; }
        public string StaticResourceName { get; set; } = null!;
        public string? StaticResourceDescription { get; set; }

        public virtual ICollection<StaticResource> StaticResources { get; set; }
    }
}
