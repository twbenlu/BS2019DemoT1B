using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Penalty
    {
        public Penalty()
        {
            UnifiedPenalty = new HashSet<UnifiedPenalty>();
        }

        public Guid PenaltyId { get; set; }
        public string Event { get; set; }
        public string LegalBasis { get; set; }
        public string StatutoryLaw { get; set; }
        public string Note { get; set; }

        public ICollection<UnifiedPenalty> UnifiedPenalty { get; set; }
    }
}
