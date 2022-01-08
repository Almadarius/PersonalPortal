using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContentIdeaCategoryMedium
    {
        public int ContentIdeaId { get; set; }
        public int ContentCategoryId { get; set; }
        public int ContentMediumId { get; set; }

        public virtual ContentCategory ContentCategory { get; set; } = null!;
        public virtual ContentIdea ContentIdea { get; set; } = null!;
        public virtual ContentMedium ContentMedium { get; set; } = null!;
    }
}
