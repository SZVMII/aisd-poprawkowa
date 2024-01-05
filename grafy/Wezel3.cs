using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Wezel3
    {
        public int wartosc;
        public List<Wezel3> sasiedzi = new List<Wezel3>();
        public Wezel3(int liczba)
        {
            this.wartosc = liczba;
        }

        public Wezel3 rodzic;
        public Wezel3 leweDziecko;
        public Wezel3 praweDziecko;

        internal void Add(int liczba)
        {
            Wezel3 dziecko = new Wezel3(liczba);
            dziecko.rodzic = this;

            if (liczba < this.wartosc)
            {
                leweDziecko = dziecko;
            }
            else
            {
                praweDziecko = dziecko;
            }
        }

        internal int getLiczbaDzieci()
        {
            int wynik = 0;
            if(this.leweDziecko != null)
                wynik++;
            if(this.praweDziecko != null)
                wynik++;

            return wynik;
        }
    }
}
