namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string wynik;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k1 = new Wezel(5);
            var k2 = new Wezel(3);
            var k3 = new Wezel(4);
            var k4 = new Wezel(1);
            var k5 = new Wezel(2);
            var k6 = new Wezel(7);

            k1.dzieci.Add(k2);
            k1.dzieci.Add(k3);
            k1.dzieci.Add(k4);

            k2.dzieci.Add(k5);
            k2.dzieci.Add(k6);

            wynik = "";
            A(k1);
            MessageBox.Show(wynik);
        }

        void A(Wezel w)
        {
            wynik += w.wartosc.ToString() + ", ";
            foreach (var dziecko in w.dzieci)
                A(dziecko);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s1 = new Wezel2(5);
            var s2 = new Wezel2(3);
            var s3 = new Wezel2(2);
            var s4 = new Wezel2(1);
            var s5 = new Wezel2(4);
            var s6 = new Wezel2(8);

            s1.Add(s2);
            s1.Add(s3);

            s2.Add(s4);
            s2.Add(s5);

            s3.Add(s6);

            wynik = "";
            A(s1);
            MessageBox.Show(wynik);
        }

        List<Wezel2> odwiedzony = new();
        void A(Wezel2 s)
        {
            wynik += s.wartosc.ToString() + ", ";
            odwiedzony.Add(s);
            //odwiedzony.Clear;
            foreach (var sasiad in s.sasiedzi)
            {
                if (!odwiedzony.Contains(sasiad))
                {

                    A(sasiad);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s1 = new Wezel2(5);
            var s2 = new Wezel2(3);
            var s3 = new Wezel2(2);
            var s4 = new Wezel2(1);
            var s5 = new Wezel2(4);
            var s6 = new Wezel2(8);

            s1.Add(s2);
            s1.Add(s3);

            s2.Add(s4);
            s2.Add(s5);

            s3.Add(s6);
            wynik = "";
            BFS(s1);
            MessageBox.Show(wynik);
        }

        void BFS(Wezel2 start)
        {
            Queue<Wezel2> kolejka = new Queue<Wezel2>();
            kolejka.Enqueue(start);
            odwiedzony.Clear();

            while (kolejka.Count > 0)
            {
                Wezel2 temp = kolejka.Dequeue();
                if (!odwiedzony.Contains(temp))
                {
                    wynik += temp.wartosc.ToString() + ", ";
                    odwiedzony.Add(temp);
                    foreach (var neighbor in temp.sasiedzi)
                    {
                        kolejka.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
