using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class JobBulletPoint
    {
        public int JobBulletPointId { get; set; }
        public int JobId { get; set; }
        public string BulletPointDescription { get; set; } = null!;

        public virtual Job Job { get; set; } = null!;
    }
}
