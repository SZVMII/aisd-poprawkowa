using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int iloscWezlow;
        public DrzewoBinarne(int liczba)
        {
            this.korzen = new Wezel3(liczba);
            this.iloscWezlow = 1;
        }

        public void Add(int liczba)
        {
            var rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        public Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;

            while(true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                    if (w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }                  
            }
        }

        public Wezel3 Znajdz(int liczba)
        {
            //mozna oprzec o ZnajdzRodzica
        }

        public Wezel3 ZnajdzMin(Wezel3 w)
        {

        }

        public Wezel3 ZnajdzMax(Wezel3 w)
        {

        }

        public Wezel3 Nastepnik(Wezel3 w)
        {
            /*
             * a)jeżeli jest praweDziecko -> znajdz minimum na w.praweDziecko
             * b)jeżeli nie ma praweDziecko -> idz do gory az wyjdziesz w rodzicow jako leweDziecko. Nastepnik to rodzic
             * c)jeżeli nie ma praweDziecko i nie zachodzi b) i nie moge isc w gore -> to nie ma Nastepnika
             */
        }

        public Wezel3 Poprzednik(Wezel w)
        {

        }
    }
}
