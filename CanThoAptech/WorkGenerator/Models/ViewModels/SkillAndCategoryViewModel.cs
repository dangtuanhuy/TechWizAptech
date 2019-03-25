using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkGenerator.Models.ViewModels
{
    public class SkillAndCategoryViewModel
    {
        public IEnumerable<Skill> SkillList { get; set; }
        public Skill Skill
        {
            get; set;

        }
        public List<string> CategoryList { get; set; }
    }
}
