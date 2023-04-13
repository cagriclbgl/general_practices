using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection = new ArrayList();

            collection.Add("A");
            collection.Add("B");
            collection.Add("C");
            collection.Add(2);

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
