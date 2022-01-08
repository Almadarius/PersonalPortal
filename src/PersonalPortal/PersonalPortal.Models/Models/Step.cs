using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Step
    {
        public int StepId { get; set; }
        public int PlanId { get; set; }
        public string StepName { get; set; } = null!;
        public string? StepDescription { get; set; }
        public DateTime StepStartDate { get; set; }
        public DateTime StepEndDate { get; set; }
        public int StepOrder { get; set; }

        public virtual Plan Plan { get; set; } = null!;
    }
}
