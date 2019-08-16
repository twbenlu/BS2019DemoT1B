using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Contract
    {
        public Contract()
        {
            CollectionStation = new HashSet<CollectionStation>();
            Stronghold = new HashSet<Stronghold>();
            SuppliesDetail = new HashSet<SuppliesDetail>();
        }

        public Guid ContractId { get; set; }
        public string ContractName { get; set; }
        public string ContractDesc { get; set; }
        public string ContractContent { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string Remark { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ContractPrice { get; set; }

        public ContractPrice ContractPriceNavigation { get; set; }
        public ICollection<CollectionStation> CollectionStation { get; set; }
        public ICollection<Stronghold> Stronghold { get; set; }
        public ICollection<SuppliesDetail> SuppliesDetail { get; set; }
    }
}
