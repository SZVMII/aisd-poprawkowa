using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafy
{
    public partial class Form1 : Form
    {
        String napis;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_wezel_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);
            var w2 = new Wezel(3);
            var w3 = new Wezel(4);
            var w4 = new Wezel(1);
            var w5 = new Wezel(2);
            var w6 = new Wezel(7);

            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);

            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);

            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }

        void A(Wezel w)
        {
            napis += w.wartosc.ToString() + ", ";
            foreach (var dziecko in w.dzieci)
                A(dziecko);
        }

        private void btn_wezel2_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(5);
            var w2 = new Wezel2(3);
            var w3 = new Wezel2(2);
            var w4 = new Wezel2(1);
            var w5 = new Wezel2(4);
            var w6 = new Wezel2(8);
            var w7 = new Wezel2(7);

            w1.Add(w2);
            w1.Add(w3);
            w1.Add(w4);

            w2.Add(w5);
            w2.Add(w6);

            w4.Add(w7);

            w6.Add(w7);

            odwiedzone.Clear();
            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }

        List<Wezel2> odwiedzone = new List<Wezel2>();

        void A(Wezel2 w)
        {
            odwiedzone.Add(w);

            napis += w.wartosc.ToString() + ", ";

            foreach (var sasiad in w.sasiedzi)
            {
                if(!odwiedzone.Contains(sasiad))
                {
                    A(sasiad);
                }
            }
        }

        private void binaryTree_btn_Click(object sender, EventArgs e)
        {
            var d = new DrzewoBinarne(5);

            d.Add(4);
            d.Add(8);
            d.Add(7);
            d.Add(6);
            d.Add(9);
            d.Add(7);
            d.Add(1);
            d.Add(4);
            d.Add(3);
            d.Add(6);
            d.Add(2);
            d.Add(2);

            int i = 1;
            var w = d.ZnajdzMin(d.korzen);

            var u = d.Znajdz(3);

            d.Usun(u);

            while (w != null)
            {
                MessageBox.Show(i + ": " + w.wartosc.ToString());
                i++;
                w = d.Nastepnik(w);
            }
        }
    }
}