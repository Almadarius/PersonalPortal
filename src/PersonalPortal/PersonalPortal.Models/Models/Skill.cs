using System;
using System.Collections.Generic;

namespace PersonalPortal.Models.Models
{
    public partial class Skill
    {
        public Skill()
        {
            Resumes = new HashSet<Resume>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; } = null!;
        public int Proficiency { get; set; }

        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
