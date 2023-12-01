using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Wezel2
    {
        public int wartosc;
        public List<Wezel2> sasiedzi = new List<Wezel2>();
        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
        }

        public void Add(Wezel2 w)
        {
            this.sasiedzi.Add(w);
            w.sasiedzi.Add(this);
        }
    }
}
