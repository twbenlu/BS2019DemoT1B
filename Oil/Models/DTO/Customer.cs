using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Stronghold = new HashSet<Stronghold>();
        }

        public Guid CustomerId { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string UnifromNumber { get; set; }

        public ICollection<Stronghold> Stronghold { get; set; }
    }
}
