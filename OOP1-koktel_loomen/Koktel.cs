using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_koktel_loomen
{
    class Koktel 
    {
        private string naziv;
        List<Sastojak> sastojci = new List<Sastojak>();
        protected float dcl;

        public Koktel(string naziv)
        {
            this.naziv = naziv;
        }
        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }

        public void Posluzi()
        {
            Console.WriteLine("Posluzujem koktel {0}\n", naziv);
            Console.WriteLine("Sastojci:{0}\n", sastojci.Count);
            foreach (Sastojak s in sastojci)
            {
                s.Prikazi();
                dcl+= s.VratiDecilitre();
            }
            Console.WriteLine("Potrebma je casa od najmanje dcl: {0}", dcl);
            
        }



    }
}
