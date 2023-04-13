using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel(1,"Cagri","Celebioglu");
            personel1.bilgileriGoster();
            Console.ReadLine();
        }
    }
}
