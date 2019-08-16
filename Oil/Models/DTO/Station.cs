using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Station
    {
        public Station()
        {
            Employee = new HashSet<Employee>();
            TransferDetail = new HashSet<TransferDetail>();
        }

        public Guid StationId { get; set; }
        public string StationName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Company { get; set; }
        public Guid Region { get; set; }

        public Region RegionNavigation { get; set; }
        public ICollection<Employee> Employee { get; set; }
        public ICollection<TransferDetail> TransferDetail { get; set; }
    }
}
