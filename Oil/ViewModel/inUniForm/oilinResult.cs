using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oil.ViewModel.inUniForm
{
    public class oilinResult
    {
        public string 型別名稱 { get; set; }
        public string 產品編號 { get; set; }
        public string 產品名稱 { get; set; }
        public string 包裝 { get; set; }
        public string 銷售對象 { get; set; }
        public string 交貨地點 { get; set; }
        public string 計價單位 { get; set; }
        public float 參考牌價 { get; set; }
        public string 營業稅 { get; set; }
        public string 貨物稅 { get; set; }
        public DateTime? 牌價生效時間 { get; set; }
        public string 備註 { get; set; }
    }
}
