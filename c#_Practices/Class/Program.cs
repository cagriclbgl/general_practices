using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba car = new Araba();
            car.arabaRengi = "Kirmizi";
            car.arabaModeli = "Audi";
            car.kapiSayisi = 4;
            car.MotorCalistir();
            car.kapilariKilitle();
            Console.WriteLine(car.arabaModeli);
            Console.WriteLine(car.kapiSayisi);
            Console.WriteLine(car.arabaRengi);
            Console.ReadLine(); 

        }
    }
}
