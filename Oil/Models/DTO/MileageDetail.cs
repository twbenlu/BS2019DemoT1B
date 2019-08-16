using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class MileageDetail
    {
        public Guid MileageId { get; set; }
        public Guid DeliveryCarId { get; set; }
        public DateTime Date { get; set; }
        public decimal Mileage { get; set; }

        public DeliveryCar DeliveryCar { get; set; }
    }
}
