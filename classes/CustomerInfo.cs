using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje_ef.classes
{
    public class CustomerInfo
    {
        public int MüşteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KayıtDurumu { get; set; }

        public string KayıtBirimi { get; set; }
        public string PersonelAd { get; set; }

        public string PersonelSoyad { get; set; }
        public string Mail { get; set; }

        public string Tel { get; set; }
        public string TC { get; set; }

    }
}
