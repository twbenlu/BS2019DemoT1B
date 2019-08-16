using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class InspectionDetail
    {
        public Guid InspectionId { get; set; }
        public Guid DeliveryCarId { get; set; }
        public DateTime InspectionDate { get; set; }

        public DeliveryCar DeliveryCar { get; set; }
    }
}
