using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelilaskin
{
    public partial class Form1 : Form
    {

        string filename = "c:/temp/nelilaskin.txt";

        public Form1()
        {
            InitializeComponent();
            kirjoitaKaynnistysAika();

            plus.Click += laskeSumma;
            miinus.Click += laskeErotus;
            kerto.Click += laskeTulo;
            jako.Click += laskeOsamaara;
        }

        private void kirjoitaKaynnistysAika()
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(DateTime.Now);
            }
        }

        private void tulostaTiedostoon(double vastaus)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(vastaus);
            }
        }

        private void laskeSumma(object sender, EventArgs e)
        {
            double summa = double.Parse(luku1.Text) + double.Parse(luku2.Text);
            tulos.Text = luku1.Text + " + " + luku2.Text + " = " + summa;
            if (checkBox1.Checked)
            {
                tulostaTiedostoon(summa);
            }
                
        }

        private void laskeErotus(object sender, EventArgs e)
        {
            double erotus = double.Parse(luku1.Text) - double.Parse(luku2.Text);
            tulos.Text = luku1.Text + " - " + luku2.Text + " = " + erotus;
            if (checkBox1.Checked)
            {
                tulostaTiedostoon(erotus);
            }
        }

        private void laskeTulo(object sender, EventArgs e)
        {
            double tulo = double.Parse(luku1.Text) * double.Parse(luku2.Text);
            tulos.Text = luku1.Text + " x " + luku2.Text + " = " + tulo;
            if (checkBox1.Checked)
            {
                tulostaTiedostoon(tulo);
            }
        }

        private void laskeOsamaara(object sender, EventArgs e)
        {
            double osamaara = double.Parse(luku1.Text) / double.Parse(luku2.Text);
            tulos.Text = luku1.Text + " / " + luku2.Text + " = " + osamaara;
            if (checkBox1.Checked)
            {
                tulostaTiedostoon(osamaara);
            }
        }

        private void SuljeOhjelmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vastaus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?",
            "Ohjelman lopetus", MessageBoxButtons.YesNo);
            if(vastaus == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                {
                    sw.WriteLine(DateTime.Now);
                }
                Application.Exit();
            }
        }

        private void TyhjennaKentatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control Cleartext in this.Controls)
            { 
                if (Cleartext is TextBox)
                {
                    ((TextBox)Cleartext).Text = string.Empty;
                }

            }
        }
    }
}
