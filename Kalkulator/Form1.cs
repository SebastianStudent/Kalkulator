namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzia�ania = ' ';
        private void jeden_Click(object sender, EventArgs e)
        {
            Dzia�anie(1);
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            Dzia�anie(2);
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            Dzia�anie(3);
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            Dzia�anie(4);
        }

        private void pi��_Click(object sender, EventArgs e)
        {
            Dzia�anie(5);
        }

        private void sze��_Click(object sender, EventArgs e)
        {
            Dzia�anie(6);
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            Dzia�anie(7);
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            Dzia�anie(8);
        }

        private void dziewi��_Click(object sender, EventArgs e)
        {
            Dzia�anie(9);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Dzia�anie(0);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            RodzajDzia�ania = '+';
            wynik_TextBox.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            RodzajDzia�ania = '-';
            wynik_TextBox.Text = "";
        }

        private void mno�enie_Click(object sender, EventArgs e)
        {
            RodzajDzia�ania = '*';
            wynik_TextBox.Text = "";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            RodzajDzia�ania = '/';
            wynik_TextBox.Text = "";
        }

        private void r�wna_si�_Click(object sender, EventArgs e)
        {
            switch (RodzajDzia�ania)
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
            RodzajDzia�ania = ' ';
        }
        private void Dzia�anie(int liczba)
        {
            if (RodzajDzia�ania == ' ')
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