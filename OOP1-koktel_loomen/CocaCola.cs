using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class CocaCola : Sastojak

    {
        private double dcl=(2.5);
        
        public CocaCola (double kolicina, string naziv)
        {
            this.kolicina = dcl;
            this.naziv = "Coca-Cola";
            this.opis = naziv;
        }

        public void Prikazi ()
        {
            Console.WriteLine("{0} Coca-cola {1}", kolicina, naziv);
        }
        public double UzmiDcl()
        {
            if (kolicina < 1)
            {
                return (double)kolicina * dcl;
            }
            else
            {
                return dcl;
            }

        }
    }
}
