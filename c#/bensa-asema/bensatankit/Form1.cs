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

namespace _3.Huoltoaseman_bensatankit
{
    public partial class Form1 : Form
    {
        string tankit = "";
        string tankkiensaldot = "c:/temp/bensis/bensatankit.txt";
        tilausLomake tl;
        string saldo95 = "";
        string saldo98 = "";
        string saldoDi = "";
        public Form1()
        {
            InitializeComponent();
            lueTankit();
            tl = new tilausLomake(this);
            tilaa.Click += tilausLomake;
        }

        private void lueTankit()
        {
            using (StreamReader sr = new StreamReader(tankkiensaldot))
            {
                // Read the stream to a string, and write the string to the console.
                tankit = sr.ReadToEnd();
            }
            string[] tankkienSaldot = tankit.Split(new char[] { ';' });
            label95.Text = tankkienSaldot[0];
            saldo95 = tankkienSaldot[0];
            label98.Text = tankkienSaldot[1];
            saldo98 = tankkienSaldot[1];
            labelDi.Text = tankkienSaldot[2];
            saldoDi = tankkienSaldot[2];

        }

        private void tilausLomake(object sender, EventArgs e)
        {
            if (tl == null || tl.IsDisposed)
            {
                tl = new tilausLomake(this);
            }
            tl.setSaldot(saldo95,saldo98,saldoDi);
            tl.Show();
        }

        public void paivita95Saldo(string s)
        {
            saldo95 = s;
            label95.Text = saldo95;

        }
        public void paivita98Saldo(string s)
        {
            saldo98 = s;
            label98.Text = saldo98;

        }
        public void paivitaDiSaldo(string s)
        {
            saldoDi = s;
            labelDi.Text = saldoDi;

        }
        private void talletaSaldot(object sender, FormClosingEventArgs e)
        {
            string tankit = saldo95 + ";" + saldo98 + ";" + saldoDi;
            using (StreamWriter outputFile = new StreamWriter(tankkiensaldot))
            {
                outputFile.WriteLine(tankit);
            }
        }

    }
}
