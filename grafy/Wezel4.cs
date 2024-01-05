using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Wezel4
    {
        public int wartosc;
        public List<Wezel4>listawezlow;
        public List<Krawedz>listakrwaedzi;
        public Wezel4(Krawedz k)
        {
            this.listakrwaedzi.Add(k);
            this.listawezlow.Add(k.poczatek);
            this.listawezlow.Add(k.koniec);
        }

        public int sprawdz(Krawedz k)
        {
            int wynik = 0;
            if (!listawezlow.Contains(k.poczatek))
            {
                wynik++;
            }

            if (!listawezlow.Contains(k.koniec))
            {
                wynik++;
            }

            return wynik;
        }

        public void Add(Krawedz k)
        {
            
        }

        public void join(Graf g)
        {
            foreach(var k in g.listakrwaedzi)
            {

            }
        }
    }
}
