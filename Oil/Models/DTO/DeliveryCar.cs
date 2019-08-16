using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class DeliveryCar
    {
        public DeliveryCar()
        {
            CarStatus = new HashSet<CarStatus>();
            InspectionDetail = new HashSet<InspectionDetail>();
            MileageDetail = new HashSet<MileageDetail>();
            OilManger = new HashSet<OilManger>();
            Ticket = new HashSet<Ticket>();
            TransferDetail = new HashSet<TransferDetail>();
        }

        public Guid DeliveryCarId { get; set; }
        public Guid CarOwner { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public DateTime Year { get; set; }
        public string License { get; set; }
        public string Company { get; set; }
        public string ExhaustVolume { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime? StartUseDate { get; set; }
        public string CarNumber { get; set; }
        public decimal Weight { get; set; }

        public Employee CarOwnerNavigation { get; set; }
        public ICollection<CarStatus> CarStatus { get; set; }
        public ICollection<InspectionDetail> InspectionDetail { get; set; }
        public ICollection<MileageDetail> MileageDetail { get; set; }
        public ICollection<OilManger> OilManger { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
        public ICollection<TransferDetail> TransferDetail { get; set; }
    }
}
