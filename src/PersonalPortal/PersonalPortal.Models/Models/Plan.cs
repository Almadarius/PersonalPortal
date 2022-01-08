using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Plan
    {
        public Plan()
        {
            Steps = new HashSet<Step>();
        }

        public int PlanId { get; set; }
        public string PlanName { get; set; } = null!;
        public string? PlanDescription { get; set; }
        public int PlanVersion { get; set; }
        public DateTime PlanStartDate { get; set; }

        public virtual ICollection<Step> Steps { get; set; }
    }
}
