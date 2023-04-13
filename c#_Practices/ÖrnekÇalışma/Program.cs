using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekÇalışma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int count = 0;
            int count2 = 0;
            int sumcift = 0;
            int sumtek = 0;


            /*for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please entered a number = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] %2 ==0)
                {
                    sumcift = sumcift + numbers[i];
                    count++;
                }
                
            }
            Console.WriteLine("Çift sayı adedi = " + count);
            Console.WriteLine("Çift sayıların toplamı = " +sumcift);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sumtek = sumtek + numbers[i];
                    count2++;
                }

            }
            Console.WriteLine("Tek sayıların toplamı = "+sumtek);
            Console.WriteLine("Tek sayı adedi = "+count2);
            

            if(sumcift > sumtek)
            {
                Console.WriteLine("Çift sayıların toplamı Tek sayıların toplamından büyüktür...");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı Çift sayıların toplamından büyüktür...");            
            }*/
            //SelamVer();
            //ÇarpımYap(5, 3);
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz = ");
                int say2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = kareAl(say2);
                Console.Clear();

                if (sonuc < 25)
                {
                    Console.WriteLine("{0} Karesi 25' ten küçüktür!", say2);
                }
                else if (sonuc > 25)
                {
                    Console.WriteLine("{0} Karesi 25' ten büyüktür!", say2);
                }
                else
                {
                    Console.WriteLine("{0} Karesi 25' e eşittir",say2);
                }
                
            }*/
            

           /* for (int i = 0; i <15; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz = ");
                int num = Convert.ToInt32(Console.ReadLine());
                TekCift(num);
            }*/
            Console.WriteLine("Lütfen kontrol etmek istediğiniz ilk sayıyı giriniz = ");
            int say3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kontrol etmek istediğiniz ikinci sayıyı giriniz = ");
            int say4 = Convert.ToInt32(Console.ReadLine());

            KontrolEt(say3,say4);
            
            
            Console.ReadLine();


            

        }

        static void SelamVer()
        {
            Console.WriteLine("Selamlarrr ...");
        }

        static void ÇarpımYap(int num1,int num2)
        {
            Console.WriteLine("Çarpım = " + (num1 * num2));
        }
        
        static int kareAl(int say1)
        {

            return say1 * say1;
        }

        static void TekCift(int number)
        {

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }
        }
        static void KontrolEt(int num1, int num2)
        {
            if (num1<num2)
            {
                Console.WriteLine("{0} > {1}",num2,num1);
            }
            else
            {
                Console.WriteLine("{0} < {1}",num2,num1);
            }
        }
    }
}
