using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class OilManger
    {
        public Guid Id { get; set; }
        public string CarNumber { get; set; }
        public string Oilname { get; set; }
        public string OilQuantity { get; set; }
        public string Mileage { get; set; }
        public DateTime? Date { get; set; }
        public double? OilMoney { get; set; }
        public string Card { get; set; }
        public Guid? OilId { get; set; }
        public Guid? CarId { get; set; }

        public DeliveryCar Car { get; set; }
        public OilDetail Oil { get; set; }
    }
}
