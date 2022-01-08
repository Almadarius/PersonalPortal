using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContentMedium
    {
        public ContentMedium()
        {
            ContentIdeaCategoryMedia = new HashSet<ContentIdeaCategoryMedium>();
        }

        public int ContentMediumId { get; set; }
        public string ContentMediumName { get; set; } = null!;
        public string? ContentMediumDescription { get; set; }

        public virtual ICollection<ContentIdeaCategoryMedium> ContentIdeaCategoryMedia { get; set; }
    }
}
