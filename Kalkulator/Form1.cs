namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzia³ania = ' ';
        private void jeden_Click(object sender, EventArgs e)
        {
            Dzia³anie(1);
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            Dzia³anie(2);
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            Dzia³anie(3);
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            Dzia³anie(4);
        }

        private void piêæ_Click(object sender, EventArgs e)
        {
            Dzia³anie(5);
        }

        private void szeœæ_Click(object sender, EventArgs e)
        {
            Dzia³anie(6);
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            Dzia³anie(7);
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            Dzia³anie(8);
        }

        private void dziewiêæ_Click(object sender, EventArgs e)
        {
            Dzia³anie(9);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Dzia³anie(0);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            RodzajDzia³ania = '+';
            wynik_TextBox.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            RodzajDzia³ania = '-';
            wynik_TextBox.Text = "";
        }

        private void mno¿enie_Click(object sender, EventArgs e)
        {
            RodzajDzia³ania = '*';
            wynik_TextBox.Text = "";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            RodzajDzia³ania = '/';
            wynik_TextBox.Text = "";
        }

        private void równa_siê_Click(object sender, EventArgs e)
        {
            switch (RodzajDzia³ania)
            {
                case ('+'):
                    wynik_TextBox.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    wynik_TextBox.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    wynik_TextBox.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    wynik_TextBox.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzia³ania = ' ';
        }
        private void Dzia³anie(int liczba)
        {
            if (RodzajDzia³ania == ' ')
            {
                LiczbaPierwsza += liczba;
                wynik_TextBox.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                wynik_TextBox.Text = LiczbaDruga;
            }
        }
    }
}