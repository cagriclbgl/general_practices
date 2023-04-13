using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyİsim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulİsmi;



        public void ogrenciBilgiGoster()
        {
            Console.WriteLine("Öğrenci Numarası = "+ogrenciNo);
            Console.WriteLine("İsim = "+isim);
            Console.WriteLine("Soyisim = "+soyİsim);
            Console.WriteLine("Vize1 = "+vize1);
            Console.WriteLine("Vize2 = "+vize2);
            Console.WriteLine("Final = "+final);
            Console.WriteLine("Okul İsmi = "+okulİsmi);
        }
        public Ogrenci(int _ogrenciNo,string _isim,string _soyİsim, int _vize1,int _vize2,int _final, string _okulİsmi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyİsim = _soyİsim;
            vize1 = _vize1;
            vize2= _vize2;  
            final = _final;
            okulİsmi = _okulİsmi;

        }

        public double ÖğrenciNotuBul()
        {
          double ort =  vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ort;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okul ismi = "+okulİsmi);
        }


    }


}

