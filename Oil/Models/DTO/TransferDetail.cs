using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class TransferDetail
    {
        public Guid TransferId { get; set; }
        public Guid DeliveryCarId { get; set; }
        public DateTime Date { get; set; }
        public Guid StationId { get; set; }

        public DeliveryCar DeliveryCar { get; set; }
        public Station Station { get; set; }
    }
}
