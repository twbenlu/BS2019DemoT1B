using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Stronghold
    {
        public Guid StrongholdId { get; set; }
        public Guid CustomerId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public Guid Contract { get; set; }
        public string Phone { get; set; }
        public string UniformNumber { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string ShippingRegion { get; set; }

        public Contract ContractNavigation { get; set; }
        public Customer Customer { get; set; }
    }
}
