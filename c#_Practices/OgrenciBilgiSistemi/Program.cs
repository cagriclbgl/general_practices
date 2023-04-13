using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(210229027,"Abdullah","Yılmaz",40,50,60,"Kocaeli Üniversitesi");
            bool control = true;
            Console.WriteLine("Uygulamamıza Hoşgeldiniz !!!");
            

            while (control)
            {
                İslemleriGoster();
                string secim = Console.ReadLine();
                
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgiGoster();
                        break;

                    case "2":
                        double ort = ogrenci1.ÖğrenciNotuBul();

                        Console.WriteLine("Öğrencini Ortalaması = " + ort);
                        break;
                        
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        control = false;
                        break;

                    default:
                        Console.WriteLine("Yanlış Tuşlama !!!");
                        break;
                }
            }
            



        }
        static void İslemleriGoster()
        {
            Console.WriteLine("1.Öğrenci Bilgileri Göster");
            Console.WriteLine("2.Öğrenci Ortalaması Göster");
            Console.WriteLine("3.Öğrenci Okulunu Göster");
            Console.WriteLine("4.Çıkış");
            


        }
    }
}
