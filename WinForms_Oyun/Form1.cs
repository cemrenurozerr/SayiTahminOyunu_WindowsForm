using System.Diagnostics.Eventing.Reader;

namespace WinForms_Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int sayi;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayi = random.Next(1, 101);
            timer1.Start();
            btnTahmin.Enabled = true;
            if (progressBar1.Value != 0)
            {
                progressBar1.Value--;

                if (progressBar1.Value < 10)
                {
                    lblHakaret.Text = "SON SANÝYELERÝNNN";
                }
                if (progressBar1.Value < 20 && progressBar1.Value > 10)
                {
                    lblHakaret.Text = "SENDEN BÝR ÞEY OLMAZZ";
                }
                if (progressBar1.Value < 30 && progressBar1.Value > 20)
                {
                    lblHakaret.Text = "KARDEÞÝM BU KADAR ZOR MUUU";

                }
                if (progressBar1.Value < 40 && progressBar1.Value > 30)
                {
                    lblHakaret.Text = "BÝR ÞEYÝ DE BÝL YAA";
                }
                if (progressBar1.Value < 50 && progressBar1.Value > 40)
                {
                    lblHakaret.Text = "HAHAHAHHAAHHA";
                }
                if (progressBar1.Value < 60 && progressBar1.Value > 50)
                {

                    lblHakaret.Text = "BECERÝKSÝZSÝNNN";
                }
            }
            else
            {

                lblSonuc.Text = "Süre Doldu Kaybettin...";
                lblHakaret.Text = "KAYBETTÝN";
                timer1.Stop();
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (sayi < nudSayi.Value)
            {
                lblSonuc.Text = $" {nudSayi.Value}'dan küçüktür..";

            }
            else if (sayi > nudSayi.Value)
            {
                lblSonuc.Text = $" {nudSayi.Value}'dan büyüktür.";

            }
            else if (sayi == nudSayi.Value)
            {
                lblSonuc.Text = "KAZANDINIZ";
                lblHakaret.Text = "KAZANDINIZ";
                timer1.Stop();
                btnTahmin.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTahmin.Enabled = false;
            timer1.Enabled = false;
            timer1.Interval = 1000;
            progressBar1.Maximum = 60;
            progressBar1.Value = 60;
            timer1.Tick += new EventHandler(btnBasla_Click);
        }
    }
}