using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class ContentCategory
    {
        public ContentCategory()
        {
            ContentIdeaCategoryMedia = new HashSet<ContentIdeaCategoryMedium>();
        }

        public int ContentCategoryId { get; set; }
        public string ContentCategoryName { get; set; } = null!;
        public string? ContentCategoryDescription { get; set; }

        public virtual ICollection<ContentIdeaCategoryMedium> ContentIdeaCategoryMedia { get; set; }
    }
}
