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
            Wezel3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        public Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    } else
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
            var w = this.korzen;
            while (w != null)
            {
                if (liczba == w.wartosc)
                {
                    return w;
                }
                else if (liczba < w.wartosc)
                {
                    w = w.leweDziecko;
                }
                else
                {
                    w = w.praweDziecko;
                }
            }
            return null;

            /*
             Wezel3 rodzic = ZnajdzRodzica(liczba);

            if (rodzic == null)
            {
                return korzen;
            }

            if (liczba < rodzic.wartosc)
            {
                return rodzic.leweDziecko;
            }

            else if(liczba > rodzic.wartosc)
            {
                return rodzic.praweDziecko;
            }
            else
            {
                return rodzic;
            }
            */
        }

        public Wezel3 ZnajdzMin(Wezel3 w)
        {
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            return w;
        }

        public Wezel3 ZnajdzMax(Wezel3 w)
        {
            while (w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }
            return w;
        }

        public Wezel3 Nastepnik(Wezel3 w)
        {
            if (w.praweDziecko != null)
            {
                return ZnajdzMin(w.praweDziecko);
            }

            Wezel3 rodzic = w.rodzic;
            while (rodzic != null && w == rodzic.praweDziecko)
            {
                w = rodzic;
                rodzic = rodzic.rodzic;
            }
            return rodzic;
        }

        public Wezel3 Poprzednik(Wezel3 w)
        {
            if (w.leweDziecko != null)
            {
                return ZnajdzMax(w.leweDziecko);
            }

            Wezel3 rodzic = w.rodzic;
            while (rodzic != null && w == rodzic.leweDziecko)
            {
                w = rodzic;
                rodzic = rodzic.rodzic;
            }
            return rodzic;
        }

        private void ReplaceNode(Wezel3 toReplace, Wezel3 replacement)
        {
            replacement.rodzic = toReplace.rodzic;

            if (toReplace.rodzic == null)
            {
                korzen = replacement;
            }
            else if (toReplace.rodzic.leweDziecko == toReplace)
            {
                toReplace.rodzic.leweDziecko = replacement;
            }
            else
            {
                toReplace.rodzic.praweDziecko = replacement;
            }
        }

        public Wezel3 Usun(Wezel3 w)
        {
            if (w.leweDziecko == null && w.praweDziecko == null)
            {
                if (w.rodzic == null)
                {
                    korzen = null;
                }
                else if (w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = null;
                }
                else
                {
                    w.rodzic.praweDziecko = null;
                }
            }
            else if (w.leweDziecko != null && w.praweDziecko == null)
            {
                ReplaceNode(w, w.leweDziecko);
            }
            else if (w.leweDziecko == null && w.praweDziecko != null)
            {
                ReplaceNode(w, w.praweDziecko);
            }
            else
            {
                Wezel3 nastepnik = Nastepnik(w);
                w.wartosc = nastepnik.wartosc;
                Usun(nastepnik);
            }

            iloscWezlow--;
            return w;
        }
    }
}
