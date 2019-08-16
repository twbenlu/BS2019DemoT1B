using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class SuppliesDetail
    {
        public Guid SuppliesDetailId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid Contract { get; set; }
        public string ContactName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public Contract ContractNavigation { get; set; }
        public Supplies Supplier { get; set; }
    }
}
