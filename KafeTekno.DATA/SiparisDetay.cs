using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeTekno.DATA
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        public string TutarTL { get { return $"₺{Tutar():n2}"; } }
        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
