using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContentIdea
    {
        public ContentIdea()
        {
            ContentIdeaCategoryMedia = new HashSet<ContentIdeaCategoryMedium>();
        }

        public int ContentIdeaId { get; set; }
        public string ContentIdeaName { get; set; } = null!;
        public string ContentIdeaDescription { get; set; } = null!;

        public virtual ICollection<ContentIdeaCategoryMedium> ContentIdeaCategoryMedia { get; set; }
    }
}
