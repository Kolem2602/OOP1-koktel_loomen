using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class Limeta : Sastojak
    {
  
        
        public Limeta (double kolicina)
        {
            this.kolicina = kolicina;
            this.naziv = "limeta";
        }
        public void Prikazi()
        {
            Console.WriteLine("{0} limete", kolicina);
        }

        public double Uzmidcl()
        {
            return kolicina;
        }
    }
   
   
}
