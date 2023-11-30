using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new List<Wezel>();
        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }

    }

}
