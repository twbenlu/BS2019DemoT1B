using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class UnifiedPenalty
    {
        public UnifiedPenalty()
        {
            Ticket = new HashSet<Ticket>();
        }

        public Guid UnifiedPenaltyId { get; set; }
        public Guid? PenaltyId { get; set; }
        public decimal? RangeOntime { get; set; }
        public decimal? RangeThirtyday { get; set; }
        public decimal? RangeSixtyday { get; set; }
        public decimal? RangeOverSixtyday { get; set; }
        public string VehicleCategory { get; set; }
        public string Violation { get; set; }

        public Penalty Penalty { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
