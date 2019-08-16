using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class ContractPrice
    {
        public ContractPrice()
        {
            Contract = new HashSet<Contract>();
        }

        public Guid ContractPriceId { get; set; }
        public decimal? ShippingCharge { get; set; }
        public decimal? PickUpCharge { get; set; }
        public decimal? TerminalCharge { get; set; }
        public decimal? SpecialService { get; set; }
        public decimal? TransitCharge { get; set; }
        public decimal? OtherCharge { get; set; }
        public decimal? TotalFreight { get; set; }

        public ICollection<Contract> Contract { get; set; }
    }
}
