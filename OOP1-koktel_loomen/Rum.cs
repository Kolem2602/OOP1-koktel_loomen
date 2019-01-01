using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class Rum : Sastojak
    {

        public Rum(double kolicina, string naziv)
        {
            this.kolicina = kolicina;
            this.naziv = naziv;
        }
        public void Prikazi()
        {
            Console.WriteLine("{0} ruma {1}", kolicina,naziv);
        }
        public double Uzmidcl()
        {
            return kolicina;
        }

    }
}
