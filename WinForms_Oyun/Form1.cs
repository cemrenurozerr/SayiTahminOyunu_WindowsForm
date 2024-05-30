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
                    lblHakaret.Text = "SON SAN�YELER�NNN";
                }
                if (progressBar1.Value < 20 && progressBar1.Value > 10)
                {
                    lblHakaret.Text = "SENDEN B�R �EY OLMAZZ";
                }
                if (progressBar1.Value < 30 && progressBar1.Value > 20)
                {
                    lblHakaret.Text = "KARDE��M BU KADAR ZOR MUUU";

                }
                if (progressBar1.Value < 40 && progressBar1.Value > 30)
                {
                    lblHakaret.Text = "B�R �EY� DE B�L YAA";
                }
                if (progressBar1.Value < 50 && progressBar1.Value > 40)
                {
                    lblHakaret.Text = "HAHAHAHHAAHHA";
                }
                if (progressBar1.Value < 60 && progressBar1.Value > 50)
                {

                    lblHakaret.Text = "BECER�KS�ZS�NNN";
                }
            }
            else
            {

                lblSonuc.Text = "S�re Doldu Kaybettin...";
                lblHakaret.Text = "KAYBETT�N";
                timer1.Stop();
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (sayi < nudSayi.Value)
            {
                lblSonuc.Text = $" {nudSayi.Value}'dan k���kt�r..";

            }
            else if (sayi > nudSayi.Value)
            {
                lblSonuc.Text = $" {nudSayi.Value}'dan b�y�kt�r.";

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