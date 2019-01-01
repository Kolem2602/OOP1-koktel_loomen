using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class Led : Sastojak 
    {
        private double dcl=1;

        public Led (string naziv)
        {
            this.kolicina = 1;
            this.naziv = "Led";
            this.opis = naziv;
            
        }

        public double UzmiDcl()
        {
            if (kolicina<1)
            {
                return kolicina * dcl;
            }
           else
            {
                return dcl;
            }
            
        }
        public void Prikazi()
        {
            Console.WriteLine("Led {0}", naziv);
        }
       
    }
}
