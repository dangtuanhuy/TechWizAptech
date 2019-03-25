using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkGenerator.Models.ViewModels
{
    public class JobsViewModel
    {
        public Job Job { get; set; }
        public IEnumerable<Skill> Skill { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
