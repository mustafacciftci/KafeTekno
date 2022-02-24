using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeTekno.DATA
{
    public class KafeVeri
    {
        public int MasaAdet { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public List<Siparis> AktifSiparisler { get; set; } = new List<Siparis>();
        public List<Siparis> GecmisSiparisler { get; set; } = new List<Siparis>();
    }
}
