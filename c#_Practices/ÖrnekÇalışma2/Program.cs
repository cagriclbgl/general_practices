using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekÇalışma2
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 5, 6, 6, 7, 8, 8, 8, 9, 10, 11, 11, 11, 12, 11, 13, 15, 20, 20 };
            int count=0;
            

            Console.WriteLine("Please enter a number you want = ");
            int number =Convert.ToInt32( Console.ReadLine());


            for(int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    count++; 
                }
                Console.WriteLine(count);
            }
            Console.WriteLine("the number of the number you entered = "+count ); 
            Console.ReadLine();
        }
    }
}
