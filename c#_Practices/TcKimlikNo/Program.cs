using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcKimlikNo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vatandaş vatandaş1 = new Vatandaş();
            vatandaş1.TcKimlik1 = "19505542472";

            Console.WriteLine("Tc Kimlik Numaranız = "+vatandaş1.TcKimlik1);

            Console.ReadLine();

        }
    }
}
