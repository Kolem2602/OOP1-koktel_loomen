using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class Sastojak 
    {
        protected double kolicina { get; set; }
        protected string naziv { get; set; }
        protected string opis { get; set; }
        protected float dcl = 0;
       public float VratiDecilitre()
        {
            return (float) kolicina;
        }
        public string VratiOpis()
        {
            return opis;
        }
        public string VratiNaziv()
        {
            return naziv;
        }
        
        public void Prikazi ()
        {
            Console.WriteLine("{0} {1} {2}", kolicina, naziv, opis);
        }


    }
}
