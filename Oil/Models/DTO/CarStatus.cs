using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class CarStatus
    {
        public Guid CarStatusId { get; set; }
        public Guid DeliveryCarId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public DeliveryCar DeliveryCar { get; set; }
    }
}
