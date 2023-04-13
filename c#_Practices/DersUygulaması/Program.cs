using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUygulaması
{
    class Çalışan
    {
        public string isim { get; }
        public string Soyisim { get; }

        public string SSN { get; }

        public string TcNo { get; }

        private decimal SatisSayisi;
        private decimal KomisyonOranı;
        public KomisyonlaÇalışan(string isim,string Soyisim,string SSN,string TcNo,decimal satisSayisi,decimal komisyonOranı)
        {
            isim = isim;
            Soyisim = Soyisim;
            SSN = SSN;
            TcNo = TcNo;
            satisSayisi = satisSayisi;
            komisyonOranı = komisyonOranı;
        }
    }
}
