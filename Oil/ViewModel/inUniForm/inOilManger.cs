using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oil.ViewModel.inUniForm
{
    public class inOilManger
    {
        public Guid Id { get; set; }
        public string CarNumber { get; set; }
        public string OilName { get; set; }
        public string OilQuantity { get; set; }
        public string Mileage { get; set; }
        public DateTime? Date { get; set; }
        public double? OilMoney { get; set; }
        public string Card { get; set; }
    }
}
