using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class CollectionStation
    {
        public Guid CollectionStationId { get; set; }
        public string CollectionStationName { get; set; }
        public Guid? Region { get; set; }
        public string Address { get; set; }
        public string OriginCompany { get; set; }
        public Guid Contract { get; set; }
        public string Tel { get; set; }

        public Contract ContractNavigation { get; set; }
        public Region RegionNavigation { get; set; }
    }
}
