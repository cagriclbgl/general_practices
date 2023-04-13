using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Kedi kedi = new Kedi();
            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_rengi = "Siyah";
            kedi.hayvan_cinsiyet = "Dişi";
            ;

            Console.WriteLine("Hayvanın yaşını giriniz = ");
            

            kedi.HayvanBilgisiGoster();
            Console.ReadLine();

        }
    }
}
