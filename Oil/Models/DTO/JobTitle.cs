using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid JobTitleId { get; set; }
        public string JobId { get; set; }
        public string JobName { get; set; }
        public string Company { get; set; }
        public string JobLevel { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
