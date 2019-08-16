using System;
using System.Collections.Generic;

namespace Oil.Models
{
    public partial class OilDetail
    {
        public OilDetail()
        {
            OilManger = new HashSet<OilManger>();
        }

        public Guid OilId { get; set; }
        public string Category { get; set; }
        public string Oilnumber { get; set; }
        public string Oilname { get; set; }
        public string Package { get; set; }
        public string Sellto { get; set; }
        public string Tradelocate { get; set; }
        public string Salesunit { get; set; }
        public double? ReferencePrice { get; set; }
        public string BusinessTax { get; set; }
        public string GoodTax { get; set; }
        public DateTime? DateTimeOffset { get; set; }
        public string Remarks { get; set; }
        public DateTime? UpdataTime { get; set; }

        public ICollection<OilManger> OilManger { get; set; }
    }
}
