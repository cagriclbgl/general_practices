using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModeli;
        public string arabaRengi;

        public void MotorCalistir()
        {
            Console.WriteLine("Motor Çalıştırıldı !!!");
        }
        public Araba()
        {

        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar Kilitlendi !!!");
        }


    }
}
