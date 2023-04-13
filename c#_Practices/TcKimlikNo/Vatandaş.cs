using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcKimlikNo
{
    public class Vatandaş
    {
        private string TcKimlikNo;
        
        
        public int karaktersayisi;

        public string TcKimlik1 
        { 
            get
            {
                return TcKimlikNo.Substring(0, 5);
            }
            
            set
            {
                bool control = false;
                
                if (value.Length < 12)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                       bool SayiMi = char.IsNumber(value[i]);
                        if (SayiMi)
                        {
                            control = false;
                        }
                        else
                        {
                            control = true;
                            
                        }
                        if (control)
                        {
                            Console.WriteLine("Girdiğiniz Tc Kimlik Numarası sadece sayılardan oluşmalıdır !!!");
                        }
                        else
                        {
                            TcKimlikNo = value;
                        }
                    }
                    
                   
                }
                else
                {
                    Console.WriteLine("Girdiğiniz Tc kimlik numarası 11 karakter değildir!!!");
                }

            }
        }
    }
}
