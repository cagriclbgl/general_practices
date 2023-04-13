using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Personel
    {
        private int KullanıcıId { get; set; }
        private string İsim { get; set; }
        private string soyİsim { get; set; }
        private static int maaş { get; set; }

        static Personel()
        {
             maaş = 3000;
        }
        public Personel( int Kullanıcıid, string isim,string soyisim)
        {
            KullanıcıId = Kullanıcıid;
            İsim = isim;
            soyİsim = soyisim; 

        }



        public void bilgileriGoster ()
        {
            Console.WriteLine("Kullanıcı Bilgileri ");
            Console.WriteLine("İd "+KullanıcıId);
            Console.WriteLine("İsim "+İsim);
            Console.WriteLine("Soyisim " + soyİsim);
            Console.WriteLine("Maaşı = "+maaş);
        }
        public void ZamYap(int zamMiktarı)
        {
            Console.WriteLine("Zam yapılıyor ...");
            Console.WriteLine("Maaş = "+maaş+zamMiktarı);
        }



    }
}
