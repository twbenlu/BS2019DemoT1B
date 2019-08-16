using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class Ticket
    {
        public Guid TicketId { get; set; }
        public DateTime? DueDate { get; set; }
        public string CasePlace { get; set; }
        public string RaiseUnit { get; set; }
        public string Filler { get; set; }
        public bool? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string TickPic { get; set; }
        public DateTime? ViolationTime { get; set; }
        public string ViolationPlace { get; set; }
        public string ViolationFact { get; set; }
        public Guid? UnifiedPenaltyId { get; set; }
        public decimal? PenaltyAmount { get; set; }
        public int? Percentage { get; set; }
        public Guid? DeliveryCarId { get; set; }
        public Guid? ViolationEmployeeId { get; set; }
        public Guid? EmployeeId { get; set; }

        public DeliveryCar DeliveryCar { get; set; }
        public Employee Employee { get; set; }
        public UnifiedPenalty UnifiedPenalty { get; set; }
        public Employee ViolationEmployee { get; set; }
    }
}
