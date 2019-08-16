using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Supplies
    {
        public Supplies()
        {
            SuppliesDetail = new HashSet<SuppliesDetail>();
        }

        public Guid SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public Guid? Region { get; set; }
        public string Tel { get; set; }

        public Region RegionNavigation { get; set; }
        public ICollection<SuppliesDetail> SuppliesDetail { get; set; }
    }
}
