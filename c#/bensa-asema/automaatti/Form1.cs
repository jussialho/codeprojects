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

namespace Maksuautomaatti_ja_mittari
{
    public partial class Form1 : Form
    {
        string hinnat = "";
        string hinnasto = "c:/temp/bensis/bensahinnat.txt";
        string tankit = "";
        string tankkienkoot = "c:/temp/bensis/bensatankit.txt";
        maksuLomake ml;
        double maksunmaara;
        string bensanlaatu;
        double litraa;

        public Form1()
        {
            InitializeComponent();
            ml = new maksuLomake(this);
            lueHinnat();
            maksa.Click += maksuLomake;
            laskehinta.Click += hintalaskuri;
            resetnappi.Click += reset;
        }

        private void hintalaskuri(object sender, EventArgs e)
        {
            double eurot = 0;
            try
            {
                //Lasketaan ja näytetään tankkauksen hinta jos litramäärä on luku > 0
                litraa = double.Parse(litrat.Text);
                if (litraa > 0)
                {
                    if (radio95.Checked)
                    {
                        eurot = double.Parse(hinta95label.Text);
                        bensanlaatu = "95E";
                    }
                    if (radio98.Checked)
                    {
                        eurot = double.Parse(hinta98label.Text);
                        bensanlaatu = "98E";
                    }
                    if (radioDi.Checked)
                    {
                        eurot = double.Parse(hintaDlabel.Text);
                        bensanlaatu = "Di";
                    }
                    double summa = Math.Round(eurot * litraa, 2);
                    this.maksunmaara = summa;
                    hinta.Text = " " + summa + " €";
                    maksa.Enabled = true;
                }
            }
            //Tyhjätään kentät jos syöte muuta kuin luku
            catch(Exception ex)
            {
                litrat.Text = "";
                hinta.Text = "";
            }
        }

        private void maksuLomake(object sender, EventArgs e)
        {
            if (ml == null || ml.IsDisposed)
            {
                ml = new maksuLomake(this);
            }
            ml.Show();
        }

        public void paivitaMaksu()
        {
            //Näytetään maksun määrä
            maksusuoritettu.Text="Maksu " + maksunmaara + " € suoritettu, kiitos!";

            //Luodaan uusi kuittitiedosto juoksevalla numerolla kuitti1, kuitti2 jne...
            string kuittitiedosto = "C:/temp/bensis/kuitit/kuitti.txt";
            string uusikuittitiedosto = kuittitiedosto;
            int count = 0;
            while (File.Exists(uusikuittitiedosto))
            {
                count++;
                uusikuittitiedosto = Path.GetDirectoryName(kuittitiedosto)
                                 + Path.DirectorySeparatorChar
                                 + Path.GetFileNameWithoutExtension(kuittitiedosto)
                                 + count.ToString()
                                 + Path.GetExtension(kuittitiedosto);
            }

            //Tulostetaan kuittiin aikaleima ja maksun tiedot
            using (StreamWriter sw = new StreamWriter(uusikuittitiedosto, false))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("********************");
                sw.WriteLine(maksunmaara + " €");
                sw.WriteLine(this.bensanlaatu + " / " + litrat.Text + " litraa");
            }
            paivitaTankit();

        }

        private void paivitaTankit()
        {
            //Haetaan tankkien saldot taulukkoon tiedostosta, jossa ne on lueteltu puolipisteellä erotettuina
            using (StreamReader sr = new StreamReader(tankkienkoot))
            {
                tankit = sr.ReadToEnd();
            }
            string[] tankkienlitrat = tankit.Split(new char[] { ';' });
            
            if (bensanlaatu == "95E")
            {
                double ysiviis = double.Parse(tankkienlitrat[0]);
                ysiviis = ysiviis - litraa;
                tankkienlitrat[0] = ysiviis.ToString();
            }
            if (bensanlaatu == "98E")
            {
                double ysikasi = double.Parse(tankkienlitrat[1]);
                ysikasi = ysikasi - litraa;
                tankkienlitrat[1] = ysikasi.ToString();
            }

            if (bensanlaatu == "Di")
            {
                double diesel = double.Parse(tankkienlitrat[2]);
                diesel = diesel - litraa;
                tankkienlitrat[2] = diesel.ToString();
            }

            //Luodaan merkkijono päivitetyllä saldolla ja kirjoitetaan tiedostoon
            tankit = tankkienlitrat[0] + ";" + tankkienlitrat[1] + ";" + tankkienlitrat[2];
            using (StreamWriter outputFile = new StreamWriter(tankkienkoot))
            {
                outputFile.WriteLine(tankit);
            }

        }

        private void lueHinnat()
        {
            //Haetaan bensahinnat taulukkoon tiedostosta, jossa ne on lueteltu puolipisteellä erotettuina
            using (StreamReader sr = new StreamReader(hinnasto))
            {
                hinnat = sr.ReadToEnd();
            }
            string[] bensojenHinnat = hinnat.Split(new char[]{ ';' });

            //Syötetään hinnat taulukosta lomakkeen kenttiin
            hinta95label.Text = bensojenHinnat[0];
            hinta98label.Text = bensojenHinnat[1];
            hintaDlabel.Text = bensojenHinnat[2];
        }

        private void reset(object sender, EventArgs e)
        {
            //Lomakkeen nollaus tyhjäksi
            foreach (Control Cleartext in this.Controls)
            {
                if (Cleartext is TextBox)
                {
                    ((TextBox)Cleartext).Text = string.Empty;
                }
                if (Cleartext is RadioButton)
                {
                    ((RadioButton)Cleartext).Checked = false;
                }
            }
            maksusuoritettu.Text = string.Empty;
        }

    }
}
