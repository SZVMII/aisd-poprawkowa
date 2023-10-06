namespace aidspoprSzymek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("kliknales w guziczek przystojniaku");
            int liczbaN = (int)liczba.Value;
            int wynik = fibo(liczbaN);
            MessageBox.Show(wynik.ToString());
        }

        int fibo(int x)
        {
           if(x == 0)
            {
                return 0;
            }
           if(x==1)
            {
                return 1;
            }
            return fibo(x - 1) + fibo(x - 2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
