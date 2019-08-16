using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Region
    {
        public Region()
        {
            CollectionStation = new HashSet<CollectionStation>();
            Station = new HashSet<Station>();
            Supplies = new HashSet<Supplies>();
        }

        public Guid RegionId { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public ICollection<CollectionStation> CollectionStation { get; set; }
        public ICollection<Station> Station { get; set; }
        public ICollection<Supplies> Supplies { get; set; }
    }
}
